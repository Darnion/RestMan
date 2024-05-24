using RestMan.Context;
using RestMan.Context.Models;
using RestMan.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        private List<OrderMenuItem> savedList = new List<OrderMenuItem>();
        private readonly Order savedOrder;
        private bool isPaymentsState = false;
        private int total = 0;
        private int paidByCash = 0;
        private int paidByCredit = 0;
        private int paidByGiftCard = 0;
        private int paidByQR = 0;
        private int totalPaid = 0;
        private int remainToPay = 0;
        private int change = 0;
        private bool isSaved = false;
        public Order Order { get; set; }
        public List<OrderMenuItem> OrderMenuItems { get; set; }
        public EditOrderForm(Order order)
        {
            InitializeComponent();
            this.Order = order;
            this.savedOrder = order;
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
            foreach (var item in this.OrderMenuItems)
            {
                savedList.Add((OrderMenuItem)item.Clone());
            }

            toolStripStatusLabelFullname.Text = CurrentUser.User.Fullname;
            toolStripStatusLabelRole.Text = CurrentUser.User.Role.Title;

            panelControls.Enabled 
                = flowLayoutPanelMenuItems.Enabled 
                = groupBoxMenuSearch.Enabled 
                = !Order.DeletedAt.HasValue;
            buttonCloseOrder.Enabled = dataGridViewOrderMenuItems.RowCount > 0;
            buttonEditWaiter.Visible
                = buttonCloseOrder.Visible
                = buttonEditTable.Visible
                = CurrentUser.IsCashier() || CurrentUser.IsManager();
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
            flowLayoutPanelMenuItems.Controls.Clear();

            if (!string.IsNullOrEmpty(textBoxMenuSearch.Text))
            {
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

        private void GetPayments()
        {
            total = 0;

            foreach (DataGridViewRow row in dataGridViewOrderMenuItems.Rows)
            {
                int.TryParse(row.Cells["ColumnTotal"].Value.ToString(), out var value);
                total += value;
            }

            paidByCash = Order.PaidByCash ?? 0;
            paidByCredit = Order.PaidByCredit ?? 0;
            paidByGiftCard = Order.PaidByGiftCard ?? 0;
            paidByQR = Order.PaidByQR ?? 0;
            change = Order.ChangeGiven ?? 0;
            totalPaid = paidByCash + paidByCredit + paidByGiftCard + paidByQR;
            remainToPay = total - totalPaid;
        }

        private void GetCurrentOrder()
        {
            using (var db = new RestManDbContext())
            {
                this.Order = db.Orders
                    .Include(x => x.Waiter)
                    .Include(x => x.Table)
                    .FirstOrDefault(x => x.Id == Order.Id);
            }
        }

        private void GetPayments()
        {
            total = 0;

            foreach (DataGridViewRow row in dataGridViewOrderMenuItems.Rows)
            {
                int.TryParse(row.Cells["ColumnTotal"].Value.ToString(), out var value);
                total += value;
            }

            paidByCash = Order.PaidByCash ?? 0;
            paidByCredit = Order.PaidByCredit ?? 0;
            paidByGiftCard = Order.PaidByGiftCard ?? 0;
            paidByQR = Order.PaidByQR ?? 0;
            change = Order.ChangeGiven ?? 0;
            totalPaid = paidByCash + paidByCredit + paidByGiftCard + paidByQR;
            remainToPay = total - totalPaid;
        }

        private void GetCurrentOrder()
        {
            using (var db = new RestManDbContext())
            {
                this.Order = db.Orders
                    .Include(x => x.Waiter)
                    .Include(x => x.Table)
                    .FirstOrDefault(x => x.Id == Order.Id);
            }
        }

        private void OrderPaymentsHandler()
        {
            panelPayments.Controls.Clear();

            using (var db = new RestManDbContext())
            {
                if (dataGridViewOrderMenuItems.RowCount > 0)
                {
                    GetPayments();

                    if (change > 0)
                    {
                        new InfoRowView("Выдано сдачи: ", change.ToString())
                        {
                            Parent = panelPayments,
                            Dock = DockStyle.Top,
                        };
                    }

                    if (totalPaid > 0)
                    {
                        new InfoRowView("Осталось оплатить: ", remainToPay.ToString())
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
            if (isPaymentsState)
            {
                SetPaymentsState();

                return;
            }

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
            var editWaiterForm = new EditWaiterForm()
            {
                Waiter = Order.Waiter,
            };

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

                ShowOrderInfo();
            };
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
            isPaymentsState = !isPaymentsState;

            SetPaymentsState();
        }

        private void SetPaymentsState()
        {
            if (isPaymentsState && remainToPay < 0)
            {
                buttonCloseOrder.Enabled = false;
                flowLayoutPanelMenuItems.Controls.Clear();

                var buttonChange = new Button
                {
                    Text = "Дать сдачу",
                    Size = new Size(100, 100),
                    Parent = flowLayoutPanelMenuItems
                };
                buttonChange.Click += buttonChange_Click;

                AddResetButton();

                return;
            }

            if (remainToPay == 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите закрыть заказ?",
                    "Подтвердите действие",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ChangeOrderState(true);

                    this.Close();
                    return;
                }
                
                ClearPayments();

                UpdatePayments();
            }

            buttonEditWaiter.Visible
                = buttonEditOrderMenuItem.Visible
                = buttonDeleteOrderMenuItem.Visible
                = groupBoxMenuSearch.Visible
                = !isPaymentsState;

            buttonCloseOrder.Enabled = totalPaid == 0;
            buttonCloseOrder.Text = isPaymentsState
                ? "Меню"
                : "Оплатить заказ";

            if (!isPaymentsState)
            {
                MenuControlsHandler();
                return;
            }

            FillPaymentsControls();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                var order = db.Orders.FirstOrDefault(x => x.Id == this.Order.Id);

                order.ChangeGiven = -remainToPay;
                order.PaidByCash += remainToPay;

                db.SaveChanges();

                UpdatePayments();
            }
        }

        private void FillPaymentsControls()
        {
            flowLayoutPanelMenuItems.Controls.Clear();

            var buttonCash = new Button
            {
                Text = "Наличные",
                Tag = "Cash",
                Size = new Size(100, 100),
                Parent = flowLayoutPanelMenuItems
            };
            buttonCash.Click += buttonPayments_Click;

            var buttonCredit = new Button
            {
                Text = "Банковская карта",
                Tag = "Credit",
                Size = new Size(100, 100),
                Parent = flowLayoutPanelMenuItems
            };
            buttonCredit.Click += buttonPayments_Click;

            var buttonGift = new Button
            {
                Text = "Подарочная карта",
                Tag = "Gift",
                Size = new Size(100, 100),
                Parent = flowLayoutPanelMenuItems
            };
            buttonGift.Click += buttonPayments_Click;

            var buttonQR = new Button
            {
                Text = "СБП",
                Tag = "QR",
                Size = new Size(100, 100),
                Parent = flowLayoutPanelMenuItems
            };
            buttonQR.Click += buttonPayments_Click;

            AddResetButton();
        }

        private void buttonPayments_Click(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                var order = db.Orders.FirstOrDefault(x => x.Id == this.Order.Id);

                switch (((Button)sender).Tag?.ToString())
                {
                    case "Cash":
                        FillCashControls();
                        return;

                    case "Credit":
                        order.PaidByCredit = remainToPay + paidByCredit;
                        break;

                    case "Gift":
                        {
                            var editCountForm = new EditCountForm()
                            {
                                Count = remainToPay,
                            };
                            editCountForm.MaxValue = remainToPay + paidByGiftCard;

                            if (editCountForm.ShowDialog() == DialogResult.OK)
                            {
                                order.PaidByGiftCard = editCountForm.Count;
                            }
                        }
                        break;

                    case "QR":
                        order.PaidByQR = remainToPay - paidByQR;
                        break;

                    default:
                        {
                            order.PaidByCash = 0;
                            order.PaidByCredit = 0;
                            order.PaidByGiftCard = 0;
                            order.PaidByQR = 0;
                            order.ChangeGiven = 0;
                        }
                        break;
                }

                db.SaveChanges();

                UpdatePayments();
            }
        }

        private void FillCashControls()
        {
            flowLayoutPanelMenuItems.Controls.Clear();

            AddBackButton();

            int[] nominals = { 2, 5, 10, 50, 100, 200, 500, 1000, 2000, 5000 };
            var controls = new Dictionary<int, string>
            {
                { remainToPay, remainToPay.ToString() }
            };

            foreach (var nominal in nominals)
            {
                var rest = remainToPay % nominal;

                if (rest != 0)
                {
                    var paid = remainToPay - rest + nominal;

                    if (controls.ContainsKey(paid))
                    {
                        continue;
                    }

                    controls.Add(paid, $"{paid} (-{paid - remainToPay})");
                }
            }

            foreach (var control in controls)
            {
                var button = new Button()
                {
                    Text = control.Value,
                    Tag = control.Key,
                    Size = new Size(100, 100),
                    Parent = flowLayoutPanelMenuItems,
                };

                button.Click += buttonCashPay_Click;
            }

            var buttonAnotherSum = new Button()
            {
                Text = "Другая сумма",
                Size = new Size(100, 100),
                Parent = flowLayoutPanelMenuItems,
            };

            buttonAnotherSum.Click += buttonAnotherSum_Click;
        }

        private void AddResetButton()
        {
            var buttonReset = new Button
            {
                Text = "Сбросить",
                Size = new Size(100, 100),
                Parent = flowLayoutPanelMenuItems
            };
            buttonReset.Click += buttonPayments_Click;
        }

        private void buttonCashPay_Click(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                var order = db.Orders.FirstOrDefault(o => o.Id == this.Order.Id);

                int.TryParse(((Button)sender).Tag.ToString(), out var cashPaid);

                order.PaidByCash = cashPaid;

                db.SaveChanges();

                UpdatePayments();
            }
        }

        private void buttonAnotherSum_Click(object sender, EventArgs e)
        {
            var editCountForm = new EditCountForm();
            editCountForm.MaxValue = remainToPay + paidByCash;

            if (editCountForm.ShowDialog() == DialogResult.OK)
            {
                using (var db = new RestManDbContext())
                {
                    var order = db.Orders.FirstOrDefault(o => o.Id == this.Order.Id);

                    order.PaidByCash = editCountForm.Count;

                    db.SaveChanges();

                    UpdatePayments();
                }
            }
        }

        private void UpdatePayments()
        {
            GetCurrentOrder();
            OrderPaymentsHandler();
            SetPaymentsState();
        }

        private void ShowOrderInfo()
        {
            panelInfo.Controls.Clear();

            new OrderCardView(Order, new List<OrderMenuItem>(), false)
            {
                Parent = panelInfo,
                Dock = DockStyle.Top
            };

            if (Order.DeletedAt.HasValue)
            {
                new Button()
                {
                    Text = "Открыть заказ",
                    Height = 46,
                    Dock = DockStyle.Bottom,
                    Parent = panelInfo,
                }
                .Click += buttonOpenOrder_Click;

                return;
            }

            new Button()
            {
                Text = "Сохранить заказ",
                Height = 46,
                Dock = DockStyle.Bottom,
                Parent = panelInfo,
            }
            .Click += buttonSaveOrder_Click;

            new Button()
            {
                Text = "Удалить заказ",
                Height = 46,
                Dock = DockStyle.Bottom,
                Parent = panelInfo,
            }
            .Click += buttonDeleteOrder_Click;
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (OrderMenuItems.Count != 0 && !CurrentUser.IsManager())
            {
                MessageBox.Show("Отказано в доступе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить заказ?",
                "Подтвердите действие",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (var db = new RestManDbContext())
                {
                    var order = db.Orders.FirstOrDefault(x => x.Id == Order.Id);

                    db.Orders.Remove(order);
                    db.SaveChanges();
                }

                isSaved = true;
                this.Close();
            }
        }

        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            isSaved = true;
            this.Close();
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

        private void dataGridViewOrderMenuItems_Paint(object sender, PaintEventArgs e)
        {
            buttonCloseOrder.Enabled = dataGridViewOrderMenuItems.RowCount > 0;
        }

        private void buttonOpenOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите открыть заказ?",
                "Подтвердите действие",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ChangeOrderState(false);

                this.Close();
            }
        }

        private void ChangeOrderState(bool toClose)
        {
            using (var db = new RestManDbContext())
            {
                var order = db.Orders.FirstOrDefault(x => x.Id == this.Order.Id);

                if (toClose)
                {
                    order.DeletedAt = DateTime.Now;
                }
                else 
                { 
                    order.DeletedAt = null;
                }

                db.SaveChanges();
            }

            isSaved = true;
        }

        private void EditOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSaved
                || !CheckForChanges())
            {
                return;
            }

            switch (MessageBox.Show("Вы хотите сохранить изменения?",
                "Подтвердите действие",
                MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.No:
                    GoToStartState();
                    break;

                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;

                default:

                    break;
            }

            if (remainToPay != 0)
            {
                ClearPayments();
            }
        }

        private bool CheckForChanges()
        {
            if (orderMenuItemsCurrent.Count > 0)
            {
                return true;
            }

            if (!savedList.SequenceEqual(OrderMenuItems))
            {
                return true;
            }

            return false;
        }

        private void GoToStartState()
        {
            using (var db = new RestManDbContext())
            {
                var order = db.Orders.FirstOrDefault(x => x.Id == Order.Id);

                if (OrderMenuItems.Count == 0)
                {
                    db.Orders.Remove(order);
                    db.SaveChanges();

                    return;
                }

                order.WaiterId = savedOrder.WaiterId;
                order.PaidByCash = savedOrder.PaidByCash;
                order.PaidByCredit = savedOrder.PaidByCredit;
                order.PaidByGiftCard = savedOrder.PaidByGiftCard;
                order.PaidByQR = savedOrder.PaidByQR;
                order.ChangeGiven = savedOrder.ChangeGiven;
                order.TableId = savedOrder.TableId;

                var orderMenuItems = db.OrderMenuItems.Where(x => x.OrderId == order.Id);

                foreach (var menuItem in orderMenuItems)
                {
                    if (!OrderMenuItems.Exists(x => x.Id == menuItem.Id))
                    {
                        db.OrderMenuItems.Remove(menuItem);
                    }
                }

                db.SaveChanges();
            }
        }

        private void ClearPayments()
        {
            using (var db = new RestManDbContext())
            {
                var order = db.Orders.FirstOrDefault(x => x.Id == Order.Id);

                order.PaidByCash = 0;
                order.PaidByCredit = 0;
                order.PaidByGiftCard = 0;
                order.PaidByQR = 0;
                order.ChangeGiven = 0;

                db.SaveChanges();
            }
        }

        private void buttonEditTable_Click(object sender, EventArgs e)
        {
            var editTableForm = new EditTableForm()
            {
                Table = Order.Table,
            };

            if (editTableForm.ShowDialog() == DialogResult.OK)
            {
                using (var db = new RestManDbContext())
                {
                    var order = db.Orders.FirstOrDefault(x => x.Id == Order.Id);

                    order.TableId = editTableForm.Table.Id;

                    db.SaveChanges();

                    Order = db.Orders
                        .Include(x => x.Table)
                        .Include(x => x.Waiter)
                        .FirstOrDefault(x => x.Id == Order.Id);
                }

                ShowOrderInfo();
            };
        }
    }
}
