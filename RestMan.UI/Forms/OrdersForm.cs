using RestMan.Context;
using RestMan.Context.Models;
using RestMan.UI.StaticClasses;
using RestMan.UI.UserControls;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RestMan.UI.Forms
{
    public partial class OrdersForm : Form
    {
        public bool IsActualOrders { get; set; }
        public OrdersForm(bool isActualOrders)
        {
            InitializeComponent();
            this.IsActualOrders = isActualOrders;
            this.Text = isActualOrders
                ? "Актуальные заказы"
                : "Завершенные заказы";
        }

        private void InitOrderCards(bool isActualOrders)
        {
            flowLayoutPanelOrders.Controls.Clear();

            using (var db = new RestManDbContext())
            {
                var amICashier = CurrentUser.IsCashier();
                var amIManager = CurrentUser.IsManager();

                var orders = db.Orders
                            .Include(x => x.Table)
                            .Include(x => x.Waiter)
                            .Where(x => x.DeletedAt.HasValue != isActualOrders
                                        && x.ShiftId == CurrentShift.Shift.Id
                                        && (amICashier
                                            || amIManager
                                            || x.WaiterId == CurrentUser.User.Id))
                            .OrderByDescending(x => x.CreatedAt)
                            .ToList();

                foreach (var order in orders)
                {
                    var orderMenuItems = db.OrderMenuItems
                                        .Include(x => x.Order)
                                        .Include(x => x.MenuItem)
                                        .Where(x => x.OrderId == order.Id)
                                        .ToList();

                    var orderCard = new OrderCardView(order, orderMenuItems, true)
                    {
                        Parent = flowLayoutPanelOrders
                    };
                }
            }

            Filter();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelFullname.Text = CurrentUser.User.Fullname;
            toolStripStatusLabelRole.Text = CurrentUser.User.Role.Title;

            buttonAddOrder.Visible = IsActualOrders;
            labelWaiter.Visible = comboBoxWaiter.Visible = !CurrentUser.IsWaiter();

            using (var db = new RestManDbContext())
            {
                comboBoxHalls.Items.Clear();
                comboBoxHalls.Items.AddRange(db.Halls.ToArray());
                comboBoxHalls.Items.Insert(0, new Hall()
                {
                    Id = -1,
                    Title = "Все залы",
                });
                comboBoxHalls.DisplayMember = nameof(Hall.Title);
                comboBoxHalls.SelectedIndex = 0;

                var orders = db.Orders.Where(x => x.ShiftId == CurrentShift.Shift.Id)
                                      .Select(x => x.WaiterId)
                                      .ToList();

                comboBoxWaiter.Items.Clear();
                comboBoxWaiter.Items.AddRange(db.Users.Where(x => (orders.Contains(x.Id)
                                                                   || x.IsOnShift == true)
                                                             && x.RoleId != 4
                                                             && db.Orders.Where(y => y.WaiterId == x.Id
                                                                                && !y.DeletedAt.HasValue).Count() > 0)
                                                            .ToArray());
                comboBoxWaiter.Items.Insert(0, new User()
                {
                    Id = -1,
                    Fullname = "Все официанты",
                });
                comboBoxWaiter.DisplayMember = nameof(User.Fullname);
                comboBoxWaiter.SelectedIndex = 0;
            }
        }

        private void comboBoxHalls_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTable.Visible = comboBoxTable.Visible = ((Hall)comboBoxHalls.SelectedItem).Id != -1;

            if (sender.Equals(comboBoxHalls))
            {
                FillTablesByHall();
            }

            Filter();
        }

        private void FillTablesByHall()
        {
            using (var db = new RestManDbContext())
            {
                var hall = (Hall)comboBoxHalls.SelectedItem;

                if (hall == null)
                {
                    return;
                }

                comboBoxTable.Items.Clear();
                comboBoxTable.Items.AddRange(db.Tables.Where(x => x.HallId == hall.Id
                                                                && db.Orders.Where(y => y.TableId == x.Id
                                                                                && !y.DeletedAt.HasValue).Count() > 0)
                                                                            .ToArray());
                comboBoxTable.Items.Insert(0, new Table()
                {
                    Id = -1,
                    Title = "Все столы",
                });
                comboBoxTable.DisplayMember = nameof(Table.Title);
                comboBoxTable.SelectedIndex = 0;
            }
        }

        private void Filter()
        {
            var hall = (Hall)comboBoxHalls.SelectedItem;
            var table = (Table)comboBoxTable.SelectedItem;
            var waiter = (User)comboBoxWaiter.SelectedItem;

            var isNotEmpty = int.TryParse(textBoxTotal.Text, out var total);

            if (hall == null || waiter == null)
            {
                return;
            }

            foreach (var control in flowLayoutPanelOrders.Controls)
            {
                if (control is OrderCardView orderCard)
                {
                    var visible = true;

                    if (hall.Id != -1 && orderCard.Order.Table.HallId != hall.Id)
                    {
                        visible = false;
                    }

                    if (table.Id != -1 && orderCard.Order.TableId != table.Id)
                    {
                        visible = false;
                    }

                    if (waiter.Id != -1 && orderCard.Order.WaiterId != waiter.Id)
                    {
                        visible = false;
                    }

                    var sum = 0;

                    foreach (var item in orderCard.OrderMenuItems)
                    {
                        sum += item.Count * item.MenuItem.Cost;
                    }

                    if (total != sum && isNotEmpty)
                    {
                        visible = false;
                    }

                    orderCard.Visible = visible;
                }
            }
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            var editTableForm = new EditTableForm();

            if (editTableForm.ShowDialog() == DialogResult.OK)
            {
                var orderDB = new Order();

                using (var db = new RestManDbContext())
                {
                    var order = new Order()
                    {
                        WaiterId = CurrentUser.User.Id,
                        ShiftId = CurrentShift.Shift.Id,
                        TableId = editTableForm.Table.Id,
                    };

                    db.Orders.Add(order);
                    db.SaveChanges();

                    orderDB = db.Orders
                        .Include(x => x.Waiter)
                        .Include(x => x.Table)
                        .ToList()
                        .LastOrDefault();
                }

                var editOrderForm = new EditOrderForm(orderDB);
                this.Hide();
                editOrderForm.ShowDialog();
                this.Show();
            }
        }

        private void OrdersForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                InitOrderCards(IsActualOrders);
            }
        }
    }
}
