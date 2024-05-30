using RestMan.Context;
using RestMan.Context.Models;
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
                            .OrderBy(x => x.CreatedAt)
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
            }
        }

        private void comboBoxHalls_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            var hall = (Hall)comboBoxHalls.SelectedItem;

            if (hall == null)
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

                    orderCard.Visible = visible;
                }
            }
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                var order = new Order()
                {
                    WaiterId = CurrentUser.User.Id,
                    ShiftId = CurrentShift.Shift.Id,
                    TableId = 1,
                };

                db.Orders.Add(order);
                db.SaveChanges();
            }

            InitOrderCards(IsActualOrders);
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
