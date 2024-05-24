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
using System.Xml.Linq;

namespace RestMan.UI.Forms
{
    public partial class EditOrderForm : Form
    {
        private Shop currentShop = null;
        private Category currentCategory = null;
        private List<Shop> shopList = null;
        private List<Category> categoryList = null;
        private List<OrderMenuItem> orderMenuItemsCurrent = new List<OrderMenuItem>();
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

            panelControls.Enabled = flowLayoutPanelMenuItems.Enabled = groupBoxMenuSearch.Enabled = !Order.DeletedAt.HasValue;
            buttonCloseOrder.Enabled = dataGridViewOrderMenuItems.RowCount > 0;
            buttonEditWaiter.Visible = buttonCloseOrder.Visible = CurrentUser.IsCashier() || CurrentUser.IsManager();
            dataGridViewOrderMenuItems.ClearSelection();

            ShowOrderInfo();
        }

        private void InitializeMenuControls()
        {
            using (var db = new RestManDbContext())
            {
                shopList = db.Shops
                    .OrderBy(x => x.Title)
                    .ToList();

                categoryList = db.Categories
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
                    var categoryId = currentCategory == null
                        ? -1
                        : currentCategory.Id;
                    var shopId = currentShop == null
                        ? -1
                        : currentShop.Id;

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
                        var button = new Button
                        {
                            Text = menuItem.Title,
                            Tag = menuItem.Id,
                            Size = new Size(100, 100),
                            Parent = flowLayoutPanelMenuItems
                        };
                        button.Click += buttonMenuItem_Click;
                    }

                    return;
                }
            }

            if (currentCategory != null)
            {
                flowLayoutPanelMenuItems.Controls.Clear();

                AddBackButton();

                using (var db = new RestManDbContext())
                {
                    var actualMenuItems = db.MenuItems
                        .Where(x => x.IsStopListed == false && x.CategoryId == currentCategory.Id)
                        .OrderBy(x => x.Title)
                        .ToList();

                    foreach (var menuItem in actualMenuItems)
                    {
                        var button = new Button
                        {
                            Text = menuItem.Title,
                            Tag = menuItem.Id,
                            Size = new Size(100, 100),
                            Parent = flowLayoutPanelMenuItems
                        };
                        button.Click += buttonMenuItem_Click;
                    }
                }

                return;
            }

            if (currentShop != null)
            {
                flowLayoutPanelMenuItems.Controls.Clear();

                AddBackButton();

                foreach (var category in categoryList.Where(x => x.ShopId == currentShop.Id))
                {
                    var button = new Button
                    {
                        Text = category.Title,
                        Tag = category.Id,
                        Size = new Size(100, 100),
                        Parent = flowLayoutPanelMenuItems
                    };
                    button.Click += buttonCategory_Click;
                }

                return;
            }

            flowLayoutPanelMenuItems.Controls.Clear();
            foreach (var shop in shopList)
            {
                var button = new Button
                {
                    Text = shop.Title,
                    Tag = shop.Id,
                    Size = new Size(100, 100),
                    Parent = flowLayoutPanelMenuItems
                };
                button.Click += buttonShop_Click;
            }
        }
        private void AddBackButton()
        {
            var buttonBack = new Button
            {
                Text = "Назад",
                Size = new Size(100, 100),
                Parent = flowLayoutPanelMenuItems
            };
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
                        Id = x.Id,
                        Title = x.MenuItem.Title,
                        Cost = x.MenuItem.Cost,
                        Count = x.Count,
                        Total = x.MenuItem.Cost * x.Count
                    })
                    .ToList();
            }

            dataGridViewOrderMenuItems.ClearSelection();
        }

        private void OrderPaymentsHandler()
        {
            panelPayments.Controls.Clear();

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

                    var paidByCash = Order.PaidByCash ?? 0;
                    var paidByCredit = Order.PaidByCredit ?? 0;
                    var paidByGiftCard = Order.PaidByGiftCard ?? 0;
                    var paidByQR = Order.PaidByQR ?? 0;
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

            int.TryParse(selection[0].Cells["ColumnId"].Value.ToString(), out var orderMenuItemId);

            buttonEditOrderMenuItem.Enabled = selection.Count == 1
                                                && (CurrentUser.IsManager()
                                                    || !OrderMenuItems.Exists(x => x.Id == orderMenuItemId));

            var isAllowToDelete = true;

            for (var i = 0; i < selection.Count; i++)
            {
                int.TryParse(selection[i].Cells["ColumnId"].Value.ToString(), out orderMenuItemId);

                if (OrderMenuItems.Exists(x => x.Id == orderMenuItemId))
                {
                    isAllowToDelete = false;
                }
            }

            buttonDeleteOrderMenuItem.Enabled = dataGridViewOrderMenuItems.SelectedRows.Count > 0
                                                && (CurrentUser.IsManager()
                                                    || isAllowToDelete);
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            if (int.TryParse(((Button)sender).Tag.ToString(), out var shopId))
            {
                currentShop = shopList.FirstOrDefault(x => x.Id == shopId);

                MenuControlsHandler();
            }
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            if (int.TryParse(((Button)sender).Tag.ToString(), out var categoryId))
            {
                currentCategory = categoryList.FirstOrDefault(x => x.Id == categoryId);

                MenuControlsHandler();
            }
        }

        private void buttonMenuItem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(((Button)sender).Tag.ToString(), out var menuItemId))
            {
                using (var db = new RestManDbContext())
                {
                    if (orderMenuItemsCurrent.Exists(x => x.MenuItemId == menuItemId))
                    {
                        var currentItem = orderMenuItemsCurrent
                            .FirstOrDefault(x => x.MenuItemId == menuItemId);

                        var orderMenuItem = db.OrderMenuItems
                                              .FirstOrDefault(x => x.Id == currentItem.Id);

                        orderMenuItem.Count++;
                        currentItem.Count++;
                    }
                    else
                    {
                        var orderMenuItem = new OrderMenuItem()
                        {
                            MenuItemId = menuItemId,
                            OrderId = this.Order.Id,
                        };

                        db.OrderMenuItems.Add(orderMenuItem);
                        orderMenuItemsCurrent.Add(orderMenuItem);
                    }
                    
                    db.SaveChanges();
                }

                OrderMenuItemsHandler();
                OrderPaymentsHandler();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (currentCategory != null)
            {
                currentCategory = null;
            }
            else if (currentShop != null)
            {
                currentShop = null;
            }

            MenuControlsHandler();
        }

        private void SetOrderMenuItemsCurrent()
        {
            using (var db = new RestManDbContext())
            {
                foreach (DataGridViewRow row in dataGridViewOrderMenuItems.Rows)
                {
                    int.TryParse(row.Cells["ColumnId"].Value.ToString(), out var orderMenuItemId);

                    if (OrderMenuItems.Exists(x => x.Id == orderMenuItemId))
                    {
                        continue;
                    }

                    orderMenuItemsCurrent.Add(db.OrderMenuItems.FirstOrDefault(x => x.Id == orderMenuItemId));
                }
            }
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
            var selectedRow = dataGridViewOrderMenuItems.SelectedRows[0];
            var rowIndex = selectedRow.Index;

            int.TryParse(selectedRow
                        .Cells["ColumnCount"]
                        .Value
                        .ToString(),
                        out var count);

            var editCountForm = new EditCountForm()
            {
                Count = count,
            };

            if (editCountForm.ShowDialog() == DialogResult.OK)
            {
                int.TryParse(selectedRow
                        .Cells["ColumnId"]
                        .Value
                        .ToString(),
                        out var id);

                using (var db = new RestManDbContext())
                {
                    db.OrderMenuItems.FirstOrDefault(x => x.Id == id).Count = editCountForm.Count;
                    db.SaveChanges();

                    if (orderMenuItemsCurrent.Exists(x => x.Id == id))
                    {
                        orderMenuItemsCurrent.FirstOrDefault(x => x.Id == id).Count = editCountForm.Count;
                    }

                    if (OrderMenuItems.Exists(x => x.Id == id))
                    {
                        OrderMenuItems.FirstOrDefault(x => x.Id == id).Count = editCountForm.Count;
                    }
                }

                OrderMenuItemsHandler();

                dataGridViewOrderMenuItems.Rows[rowIndex].Selected = true;
                dataGridViewOrderMenuItems.FirstDisplayedScrollingRowIndex = rowIndex;
            };
        }

        private void buttonDeleteOrderMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewOrderMenuItems.SelectedRows;
            var rowIndex = selectedRows[0].Index - 1;

            var element = selectedRows.Count > 1
                ? selectedRows.Count.ToString()
                : selectedRows[0].Cells["ColumnTitle"].Value.ToString()
                  + " "
                  + selectedRows[0].Cells["ColumnCount"].Value.ToString()
                  + " шт.";

            if (MessageBox.Show($"Вы уверены, что хотите удалить позиции: {element} из заказа?",
                "Подтвердите действие",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                using (var db = new RestManDbContext())
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        int.TryParse(row.Cells["ColumnId"].Value.ToString(), out var id);

                        var orderMenuItem = db.OrderMenuItems.FirstOrDefault(x => x.Id == id);

                        db.OrderMenuItems.Remove(orderMenuItem);
                        orderMenuItemsCurrent.Remove(orderMenuItem);
                        OrderMenuItems.Remove(orderMenuItem);
                    }

                    db.SaveChanges();
                }

                OrderMenuItemsHandler();

                if (rowIndex >= 0)
                {
                    dataGridViewOrderMenuItems.FirstDisplayedScrollingRowIndex = rowIndex;
                }
            }
        }

        private void buttonCloseOrder_Click(object sender, EventArgs e)
        {

        }

        private void ShowOrderInfo()
        {
            panelInfo.Controls.Clear();

            new OrderCardView(Order, new List<OrderMenuItem>(), false)
            {
                Parent = panelInfo,
                Dock = DockStyle.Top
            };
        }

        private void dataGridViewOrderMenuItems_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            int.TryParse(dataGridViewOrderMenuItems.Rows[e.RowIndex]
                .Cells["ColumnId"]
                .Value
                .ToString(),
                out var orderMenuItemId);

            if (OrderMenuItems.Exists(x => x.Id == orderMenuItemId))
            {
                dataGridViewOrderMenuItems.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Silver;
                return;
            }

            dataGridViewOrderMenuItems.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }
    }
}
