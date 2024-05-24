using RestMan.Context;
using RestMan.Context.Models;
using RestMan.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestMan.UI.Forms
{
    public partial class EditOrderForm : Form
    {
        private Shop CurrentShop = null;
        private Category CurrentCategory = null;
        private List<Shop> ShopList = null;
        private List<Category> CategoryList = null;
        public Order Order { get; set; }
        public List<OrderMenuItem> OrderMenuItems { get; set; }
        public EditOrderForm(Order order)
        {
            InitializeComponent();
            this.Order = order;
            OrderMenuItemsHandler();
            OrderPaymentsHandler();
            InitializeMenuControls();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditOrderForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelFullname.Text = CurrentUser.User.Fullname;
            toolStripStatusLabelRole.Text = CurrentUser.User.Role.Title;

            panelControls.Enabled = !Order.DeletedAt.HasValue;
            buttonCloseOrder.Enabled = dataGridViewOrderMenuItems.RowCount > 0;
            buttonEditWaiter.Visible = buttonCloseOrder.Visible = CurrentUser.IsCashier() || CurrentUser.IsManager();

            ShowOrderInfo();
        }

        private void InitializeMenuControls()
        {
            using (var db = new RestManDbContext())
            {
                ShopList = db.Shops
                    .OrderBy(x => x.Title)
                    .ToList();

                CategoryList = db.Categories
                    .OrderBy(x => x.Title)
                    .ToList();
            }

            MenuControlsHandler();
        }

        private void MenuControlsHandler()
        {
            if (!string.IsNullOrEmpty(textBoxMenuSearch.Text))
            {
                flowLayoutPanelMenuItems.Controls.Clear();

                using (var db = new RestManDbContext())
                {
                    var categoryId = CurrentCategory == null
                        ? -1
                        : CurrentCategory.Id;
                    var shopId = CurrentShop == null
                        ? -1
                        : CurrentShop.Id;

                    var actualMenuItems = db.MenuItems
                        .Include(x => x.Category)
                        .Where(x => x.IsStopListed == false
                                    && (x.CategoryId == categoryId
                                        || x.Category.ShopId == shopId
                                                || shopId == -1)
                                    && x.Title.Contains(textBoxMenuSearch.Text))
                        .OrderBy(x => x.Title)
                        .ToList();

                    foreach (var menuItem in actualMenuItems)
                    {
                        var button = new Button()
                        {
                            Text = menuItem.Title,
                            Tag = menuItem.Id
                        };
                        button.Size = new Size(100, 100);
                        button.Parent = flowLayoutPanelMenuItems;
                        button.Click += buttonMenuItem_Click;
                    }

                    return;
                }
            }

            if (CurrentCategory != null)
            {
                flowLayoutPanelMenuItems.Controls.Clear();

                AddBackButton();

                using (var db = new RestManDbContext())
                {
                    var actualMenuItems = db.MenuItems
                        .Where(x => x.IsStopListed == false && x.CategoryId == CurrentCategory.Id)
                        .OrderBy(x => x.Title)
                        .ToList();

                    foreach (var menuItem in actualMenuItems)
                    {
                        var button = new Button()
                        {
                            Text = menuItem.Title,
                            Tag = menuItem.Id
                        };
                        button.Size = new Size(100, 100);
                        button.Parent = flowLayoutPanelMenuItems;
                        button.Click += buttonMenuItem_Click;
                    }
                }

                return;
            }

            if (CurrentShop != null)
            {
                flowLayoutPanelMenuItems.Controls.Clear();

                AddBackButton();

                foreach (var category in CategoryList.Where(x => x.ShopId == CurrentShop.Id))
                {
                    var button = new Button()
                    {
                        Text = category.Title,
                        Tag = category.Id
                    };
                    button.Size = new Size(100, 100);
                    button.Parent = flowLayoutPanelMenuItems;
                    button.Click += buttonCategory_Click;
                }

                return;
            }

            flowLayoutPanelMenuItems.Controls.Clear();
            foreach (var shop in ShopList)
            {
                var button = new Button()
                {
                    Text = shop.Title,
                    Tag = shop.Id
                };
                button.Size = new Size(100, 100);
                button.Parent = flowLayoutPanelMenuItems;
                button.Click += buttonShop_Click;
            }
        }
        private void AddBackButton()
        {
            var buttonBack = new Button()
            {
                Text = "Назад",
            };
            buttonBack.Size = new Size(100, 100);
            buttonBack.Parent = flowLayoutPanelMenuItems;
            buttonBack.Click += buttonBack_Click;
        }

        private void OrderMenuItemsHandler()
        {
            using (var db = new RestManDbContext())
            {
                dataGridViewOrderMenuItems.DataSource = db.OrderMenuItems
                    .Include(x => x.Order)
                    .Include(x => x.MenuItem)
                    .Where(x => x.OrderId == this.Order.Id)
                    .ToList()
                    .Select(x => new
                    {
                        MenuItemId = x.MenuItemId,
                        Title = x.MenuItem.Title,
                        Cost = x.MenuItem.Cost,
                        Count = x.Count,
                        Total = x.MenuItem.Cost * x.Count
                    })
                    .ToList();
            }
        }

        private void OrderPaymentsHandler()
        {
            using (var db = new RestManDbContext())
            {
                var orderMenuItems = dataGridViewOrderMenuItems.Rows;

                if (orderMenuItems.Count > 0)
                {
                    var total = 0;

                    foreach (DataGridViewRow orderMenuItem in orderMenuItems)
                    {
                        int.TryParse(orderMenuItem.Cells["ColumnTotal"].Value.ToString(), out var itemCost);
                        total += itemCost;
                    }

                    var paidByCash = Order.PaidByCash.HasValue
                        ? Order.PaidByCash.Value
                        : 0;
                    var paidByCredit = Order.PaidByCredit.HasValue
                        ? Order.PaidByCredit.Value
                        : 0;
                    var paidByGiftCard = Order.PaidByGiftCard.HasValue
                        ? Order.PaidByGiftCard.Value
                        : 0;
                    var paidByQR = Order.PaidByQR.HasValue
                        ? Order.PaidByQR.Value
                        : 0;
                    var totalPaid = paidByCash + paidByCredit + paidByGiftCard + paidByQR;

                    if (totalPaid > 0)
                    {
                        new InfoRowView("Осталось оплатить: ", (total - totalPaid).ToString())
                        {
                            Parent = panelPayments,
                            Dock = DockStyle.Top,
                            BorderStyle = BorderStyle.FixedSingle,
                        };
                    }

                    if (paidByGiftCard > 0)
                    {
                        new InfoRowView("Оплачено подарочной картой: ", paidByGiftCard.ToString())
                        {
                            Parent = panelPayments,
                            Dock = DockStyle.Top,
                        };
                    }

                    if (paidByQR > 0)
                    {
                        new InfoRowView("Оплачено СБП: ", paidByQR.ToString())
                        {
                            Parent = panelPayments,
                            Dock = DockStyle.Top,
                        };
                    }

                    if (paidByCredit > 0)
                    {
                        new InfoRowView("Оплачено банковской картой: ", paidByCredit.ToString())
                        {
                            Parent = panelPayments,
                            Dock = DockStyle.Top,
                        };
                    }

                    if (paidByCash > 0)
                    {
                        new InfoRowView("Оплачено наличными: ", paidByCash.ToString())
                        {
                            Parent = panelPayments,
                            Dock = DockStyle.Top,
                        };
                    }

                    new InfoRowView("Итого: ", total.ToString())
                    {
                        Parent = panelPayments,
                        Dock = DockStyle.Top,
                        BorderStyle = BorderStyle.FixedSingle,
                    };
                }
            }
        }

        private void dataGridViewOrderMenuItems_SelectionChanged(object sender, EventArgs e)
        {
            var selection = dataGridViewOrderMenuItems.SelectedRows;

            if (!(selection.Count > 0))
            {
                buttonEditOrderMenuItem.Enabled = false;
                buttonDeleteOrderMenuItem.Enabled = false;
                return;
            }

            int.TryParse(selection[0].Cells["ColumnMenuItemId"].Value.ToString(), out var menuItemId);

            buttonEditOrderMenuItem.Enabled = selection.Count == 1
                                                && (CurrentUser.IsManager()
                                                    || !OrderMenuItems.Exists(x => x.MenuItemId == menuItemId));

            var isAllowToDelete = true;

            for (var i = 0; i < selection.Count - 1; i++)
            {
                int.TryParse(selection[i].Cells["ColumnMenuItemId"].Value.ToString(), out menuItemId);

                if (OrderMenuItems.Exists(x => x.MenuItemId == menuItemId))
                {
                    isAllowToDelete = false;
                }
            }

            buttonDeleteOrderMenuItem.Enabled = dataGridViewOrderMenuItems.SelectedRows.Count > 0
                                                && (CurrentUser.IsManager()
                                                    || isAllowToDelete);
        }

        private void dataGridViewOrderMenuItems_Paint(object sender, PaintEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewOrderMenuItems.Rows)
            {
                int.TryParse(row.Cells["ColumnMenuItemId"].Value.ToString(), out var menuItemId);

                if (OrderMenuItems.Exists(x => x.MenuItemId == menuItemId))
                {
                    row.DefaultCellStyle.BackColor = Color.Silver;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            if (int.TryParse(((Button)sender).Tag.ToString(), out var shopId))
            {
                CurrentShop = ShopList.FirstOrDefault(x => x.Id == shopId);

                MenuControlsHandler();
            }
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            if (int.TryParse(((Button)sender).Tag.ToString(), out var categoryId))
            {
                CurrentCategory = CategoryList.FirstOrDefault(x => x.Id == categoryId);

                MenuControlsHandler();
            }
        }

        private void buttonMenuItem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(((Button)sender).Tag.ToString(), out var menuItemId))
            {
                using (var db = new RestManDbContext())
                {
                    var orderMenuItem = new OrderMenuItem()
                    {
                        MenuItemId = menuItemId,
                        OrderId = this.Order.Id,
                    };

                    db.OrderMenuItems.Add(orderMenuItem);
                    db.SaveChanges();
                }

                OrderMenuItemsHandler();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (CurrentCategory != null)
            {
                CurrentCategory = null;
            }
            else if (CurrentShop != null)
            {
                CurrentShop = null;
            }

            MenuControlsHandler();
        }

        private void textBoxMenuSearch_TextChanged(object sender, EventArgs e)
        {
            MenuControlsHandler();
        }

        private void buttonEditWaiter_Click(object sender, EventArgs e)
        {
            var editWaiterForm = new EditWaiterForm(Order.Waiter);

            if (editWaiterForm.ShowDialog() == DialogResult.OK)
            {
                using (var db = new RestManDbContext())
                {
                    var order = db.Orders.FirstOrDefault(x => x.Id == Order.Id);

                    order.WaiterId = editWaiterForm.Waiter.Id;

                    db.SaveChanges();

                    Order = db.Orders
                        .Include(x => x.Table)
                        .Include(x => x.Waiter)
                        .FirstOrDefault(x => x.Id == Order.Id);
                }
            };

            ShowOrderInfo();
        }

        private void buttonEditOrderMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteOrderMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonCloseOrder_Click(object sender, EventArgs e)
        {

        }

        private void ShowOrderInfo()
        {
            panelInfo.Controls.Clear();

            var orderInfo = new OrderCardView(Order, new List<OrderMenuItem>(), false);

            orderInfo.Parent = panelInfo;
            orderInfo.Dock = DockStyle.Top;
        }
    }
}
