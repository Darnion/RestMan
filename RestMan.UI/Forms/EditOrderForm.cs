using RestMan.Context;
using RestMan.Context.Models;
using RestMan.UI.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MenuItem = RestMan.Context.Models.MenuItem;

namespace RestMan.UI.Forms
{
    public partial class EditOrderForm : Form
    {
        private Shop currentShop = null;
        private Category currentCategory = null;
        private List<Shop> shopList = null;
        private List<Category> categoryList = null;
        private List<MenuItem> menuItemList = null;
        private List<OrderMenuItem> backupList = new List<OrderMenuItem>();
        private List<OrderMenuItem> currentList = new List<OrderMenuItem>();
        private readonly Order backupOrder;
        private Order currentOrder;
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

        public EditOrderForm(Order order)
        {
            InitializeComponent();
            InitializeMenuControls();
            this.backupOrder = order;
            this.currentOrder = (Order)order.Clone();
            GetCurrentList(currentOrder);
            OrderMenuItemsHandler(currentList);
            OrderPaymentsHandler();
            
        }

        private void GetCurrentList(Order order)
        {
            using (var db = new RestManDbContext())
            {
                currentList = db.OrderMenuItems
                    .Include(x => x.MenuItem)
                    .Where(x => x.OrderId == order.Id)
                    .ToList();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditOrderForm_Load(object sender, EventArgs e)
        {
            foreach (var item in currentList)
            {
                backupList.Add((OrderMenuItem)item.Clone());
            }

            toolStripStatusLabelFullname.Text = CurrentUser.User.Fullname;
            toolStripStatusLabelRole.Text = CurrentUser.User.Role.Title;

            panelControls.Enabled
                = flowLayoutPanelMenuItems.Enabled
                = groupBoxMenuSearch.Enabled
                = !currentOrder.DeletedAt.HasValue;
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
                    .Include(x => x.Shop)
                    .OrderBy(x => x.Title)
                    .ToList();

                menuItemList = db.MenuItems
                    .OrderBy(x => x.Title)
                    .Where(x => x.IsStopListed == false)
                    .ToList();
            }

            MenuControlsHandler();
        }

        private void MenuControlsHandler()
        {
            flowLayoutPanelMenuItems.Controls.Clear();

            if (!string.IsNullOrEmpty(textBoxMenuSearch.Text))
            {
                var categoryId = currentCategory == null
                    ? -1
                    : currentCategory.Id;
                var shopId = currentShop == null
                    ? -1
                    : currentShop.Id;

                var actualMenuItems = menuItemList
                    .Where(x => (x.CategoryId == categoryId
                                    || x.Category.ShopId == shopId
                                            || shopId == -1)
                                && x.Title.ToLower().Contains(textBoxMenuSearch.Text.ToLower()))
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

            if (currentCategory != null)
            {
                AddBackButton();

                var actualMenuItems = menuItemList
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

        private void OrderMenuItemsHandler(List<OrderMenuItem> list)
        {
            dataGridViewOrderMenuItems.DataSource = list
                    .Select(x => new
                    {
                        Id = x.Id,
                        Title = menuItemList.FirstOrDefault(y => y.Id == x.MenuItemId).Title,
                        Cost = menuItemList.FirstOrDefault(y => y.Id == x.MenuItemId).Cost,
                        Count = x.Count,
                        Total = menuItemList.FirstOrDefault(y => y.Id == x.MenuItemId).Cost * x.Count
                    })
                    .ToList();

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

            paidByCash = currentOrder.PaidByCash ?? 0;
            paidByCredit = currentOrder.PaidByCredit ?? 0;
            paidByGiftCard = currentOrder.PaidByGiftCard ?? 0;
            paidByQR = currentOrder.PaidByQR ?? 0;
            change = currentOrder.ChangeGiven ?? 0;
            totalPaid = paidByCash + paidByCredit + paidByGiftCard + paidByQR;
            remainToPay = total - totalPaid;
        }

        private void GetCurrentOrder()
        {
            using (var db = new RestManDbContext())
            {
                this.currentOrder = db.Orders
                    .Include(x => x.Waiter)
                    .Include(x => x.Table)
                    .FirstOrDefault(x => x.Id == backupOrder.Id);
            }
        }

        private void OrderPaymentsHandler()
        {
            panelPayments.Controls.Clear();
            
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
                                                    || !backupList.Exists(x => x.Id == orderMenuItemId));

            var isAllowToDelete = true;

            for (var i = 0; i < selection.Count; i++)
            {
                int.TryParse(selection[i].Cells["ColumnId"].Value.ToString(), out orderMenuItemId);

                if (backupList.Exists(x => x.Id == orderMenuItemId))
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
                if (currentList.Where(x => x.MenuItemId == menuItemId
                                        && !backupList.Exists(y => y.Id == x.Id)).Count() > 0)
                {
                    currentList
                        .LastOrDefault(x => x.MenuItemId == menuItemId)
                        .Count++;
                }
                else
                {
                    var orderMenuItem = new OrderMenuItem()
                    {
                        Id = -1,
                        MenuItemId = menuItemId,
                        OrderId = backupOrder.Id,
                    };

                    currentList.Add(orderMenuItem);
                }

                OrderMenuItemsHandler(currentList);
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

        private void textBoxMenuSearch_TextChanged(object sender, EventArgs e)
        {
            MenuControlsHandler();
        }

        private void buttonEditWaiter_Click(object sender, EventArgs e)
        {
            var editWaiterForm = new EditWaiterForm()
            {
                Waiter = currentOrder.Waiter,
            };

            if (editWaiterForm.ShowDialog() == DialogResult.OK)
            {
                currentOrder.Waiter = editWaiterForm.Waiter;
                currentOrder.WaiterId = editWaiterForm.Waiter.Id;

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

                currentList.FirstOrDefault(x => x.Id == id).Count = editCountForm.Count;

                if (currentList.Exists(x => x.Id == id))
                {
                    currentList.FirstOrDefault(x => x.Id == id).Count = editCountForm.Count;
                }

                OrderMenuItemsHandler(currentList);

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
                foreach (DataGridViewRow row in selectedRows)
                {
                    int.TryParse(row.Cells["ColumnId"].Value.ToString(), out var id);

                    var orderMenuItem = currentList.FirstOrDefault(x => x.Id == id);

                    currentList.Remove(orderMenuItem);
                }

                OrderMenuItemsHandler(currentList);

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
            panelInfo.Enabled
                = buttonCloseOrder.Enabled = totalPaid == 0;

            buttonEditWaiter.Visible
                = buttonEditTable.Visible
                = buttonEditOrderMenuItem.Visible
                = buttonDeleteOrderMenuItem.Visible
                = groupBoxMenuSearch.Visible
                = !isPaymentsState;

            buttonCloseOrder.Text = isPaymentsState
                ? "Меню"
                : "Оплатить заказ";

            if (isPaymentsState && remainToPay < 0)
            {
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

            if (!isPaymentsState)
            {
                MenuControlsHandler();
                return;
            }

            FillPaymentsControls();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            currentOrder.ChangeGiven = -remainToPay;
            currentOrder.PaidByCash += remainToPay;

            UpdatePayments();
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
            switch (((Button)sender).Tag?.ToString())
            {
                case "Cash":
                    FillCashControls();
                    return;

                case "Credit":
                    currentOrder.PaidByCredit = remainToPay + paidByCredit;
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
                            currentOrder.PaidByGiftCard = editCountForm.Count;
                        }
                    }
                    break;

                case "QR":
                    currentOrder.PaidByQR = remainToPay - paidByQR;
                    break;

                default:
                    ClearPayments();
                    break;
            }

            UpdatePayments();
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
            
            int.TryParse(((Button)sender).Tag.ToString(), out var cashPaid);

            currentOrder.PaidByCash = cashPaid;

            UpdatePayments();
        }

        private void buttonAnotherSum_Click(object sender, EventArgs e)
        {
            var editCountForm = new EditCountForm();
            editCountForm.MaxValue = remainToPay + paidByCash;

            if (editCountForm.ShowDialog() == DialogResult.OK)
            {
                currentOrder.PaidByCash = editCountForm.Count;

                UpdatePayments();
            }
        }

        private void UpdatePayments()
        {
            OrderPaymentsHandler();
            SetPaymentsState();
        }

        private void ShowOrderInfo()
        {
            panelInfo.Controls.Clear();

            new OrderCardView(currentOrder, new List<OrderMenuItem>(), false)
            {
                Parent = panelInfo,
                Dock = DockStyle.Top
            };

            if (currentOrder.DeletedAt.HasValue)
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
            if (currentList.Count != 0 && !CurrentUser.IsManager())
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
                    var order = db.Orders.FirstOrDefault(x => x.Id == currentOrder.Id);

                    db.Orders.Remove(order);
                    db.SaveChanges();
                }

                isSaved = true;
                this.Close();
            }
        }

        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            SaveOrder();
            this.Close();
        }

        private void dataGridViewOrderMenuItems_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            int.TryParse(dataGridViewOrderMenuItems.Rows[e.RowIndex]
                .Cells["ColumnId"]
                .Value
                .ToString(),
                out var orderMenuItemId);

            if (backupList.Exists(x => x.Id == orderMenuItemId))
            {
                dataGridViewOrderMenuItems.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Silver;
                return;
            }

            dataGridViewOrderMenuItems.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }

        private void dataGridViewOrderMenuItems_Paint(object sender, PaintEventArgs e)
        {
            buttonCloseOrder.Enabled = dataGridViewOrderMenuItems.RowCount > 0
                && !isPaymentsState;
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
                var order = db.Orders.FirstOrDefault(x => x.Id == this.currentOrder.Id);

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

            if (currentList.Count == 0
                && MessageBox.Show("Удалить пустой заказ?",
                "Подтвердите действие",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new RestManDbContext())
                {
                    var order = db.Orders.FirstOrDefault(x => x.Id == currentOrder.Id);

                    db.Orders.Remove(order);
                    db.SaveChanges();
                }
            }

            switch (MessageBox.Show("Вы хотите сохранить изменения?",
                "Подтвердите действие",
                MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    SaveOrder();
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
            if (!backupList.SequenceEqual(currentList)
                || backupOrder.WaiterId != currentOrder.WaiterId
                || backupOrder.TableId != currentOrder.TableId)
            {
                return true;
            }

            return false;
        }
        
        private void SaveOrder()
        {
            using (var db = new RestManDbContext())
            {
                var order = db.Orders.FirstOrDefault(x => x.Id == backupOrder.Id);

                order.WaiterId = currentOrder.WaiterId;
                order.PaidByCash = currentOrder.PaidByCash;
                order.PaidByCredit = currentOrder.PaidByCredit;
                order.PaidByGiftCard = currentOrder.PaidByGiftCard;
                order.PaidByQR = currentOrder.PaidByQR;
                order.ChangeGiven = currentOrder.ChangeGiven;
                order.TableId = currentOrder.TableId;

                foreach (var item in backupList)
                {
                    var itemCurrent = currentList.FirstOrDefault(x => x.Id == item.Id);

                    if (itemCurrent == null)
                    {
                        var itemToDelete = db.OrderMenuItems.FirstOrDefault(x => x.Id == item.Id);

                        db.OrderMenuItems.Remove(itemToDelete);
                    }
                }

                var orderMenuItems = db.OrderMenuItems.Where(x => x.OrderId == backupOrder.Id);

                foreach (var item in currentList)
                {
                    var itemDB = orderMenuItems.FirstOrDefault(x => x.Id == item.Id);

                    if (itemDB != null)
                    {
                        if (itemDB.Count != item.Count)
                        {
                            itemDB.Count = item.Count;
                        }

                        continue;
                    }

                    db.OrderMenuItems.Add(item);
                }

                db.SaveChanges();
            }

            isSaved = true;
            this.Close();
        }

        private void ClearPayments()
        {
            currentOrder.PaidByCash = 0;
            currentOrder.PaidByCredit = 0;
            currentOrder.PaidByGiftCard = 0;
            currentOrder.PaidByQR = 0;
            currentOrder.ChangeGiven = 0;
        }

        private void buttonEditTable_Click(object sender, EventArgs e)
        {
            var editTableForm = new EditTableForm()
            {
                Table = currentOrder.Table,
            };

            if (editTableForm.ShowDialog() == DialogResult.OK)
            {
                currentOrder.Table = editTableForm.Table;
                currentOrder.TableId = editTableForm.Table.Id;

                ShowOrderInfo();
            };
        }
    }
}
