using RestMan.Context;
using RestMan.Context.Models;
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
    public partial class StopListForm : Form
    {
        private Shop CurrentShop = null;
        private Category CurrentCategory = null;
        private List<Shop> ShopList = null;
        private List<Category> CategoryList = null;
        public StopListForm()
        {
            InitializeComponent();
            dataGridViewStopList.AutoGenerateColumns = false;
            InitializeStopList();
            InitializeActualList();
        }

        private void InitializeActualList()
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

            ActualListHandler();
        }

        private void InitializeStopList()
        {
            using (var db = new RestManDbContext())
            {
                dataGridViewStopList.DataSource = db.MenuItems
                                                .Where(x => x.IsStopListed == true)
                                                .OrderBy(x => x.Title)
                                                .ToList();
            }
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            if (int.TryParse(((Button)sender).Tag.ToString(), out var shopId))
            {
                CurrentShop = ShopList.FirstOrDefault(x => x.Id == shopId);

                ActualListHandler();
            }
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            if (int.TryParse(((Button)sender).Tag.ToString(), out var categoryId))
            {
                CurrentCategory = CategoryList.FirstOrDefault(x => x.Id == categoryId);

                ActualListHandler();
            }
        }

        private void buttonMenuItem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(((Button)sender).Tag.ToString(), out var menuItemId))
            {
                if (MessageBox.Show($"Вы уверены, что хотите добавить \"{((Button)sender).Text}\" в стоп-лист?",
                "Подтвердите действие",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new RestManDbContext())
                    {
                        var menuItem = db.MenuItems.SingleOrDefault(x => x.Id == menuItemId);
                        menuItem.IsStopListed = true;
                        db.SaveChanges();
                    }

                    ActualListHandler();

                    StopListFilter();
                }
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

            ActualListHandler();
        }

        private void ActualListHandler()
        {
            if (!string.IsNullOrEmpty(textBoxActualListSearch.Text))
            {
                flowLayoutPanelActualList.Controls.Clear();

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
                                    && x.Title.Contains(textBoxActualListSearch.Text))
                        .OrderBy(x => x.Title)
                        .ToList();

                    foreach (var menuItem in actualMenuItems)
                    {
                        var button = new Button
                        {
                            Text = menuItem.Title,
                            Tag = menuItem.Id,
                            Size = new Size(100, 100),
                            Parent = flowLayoutPanelActualList
                        };
                        button.Click += buttonMenuItem_Click;
                    }
                }

                return;
            }
            
            if (CurrentCategory != null)
            {
                flowLayoutPanelActualList.Controls.Clear();

                AddBackButton();

                using (var db = new RestManDbContext())
                {
                    var actualMenuItems = db.MenuItems
                        .Where(x => x.IsStopListed == false && x.CategoryId == CurrentCategory.Id)
                        .OrderBy(x => x.Title)
                        .ToList();

                    foreach (var menuItem in actualMenuItems)
                    {
                        var button = new Button
                        {
                            Text = menuItem.Title,
                            Tag = menuItem.Id,
                            Size = new Size(100, 100),
                            Parent = flowLayoutPanelActualList
                        };
                        button.Click += buttonMenuItem_Click;
                    }
                }

                return;
            }

            if (CurrentShop != null)
            {
                flowLayoutPanelActualList.Controls.Clear();

                AddBackButton();

                foreach (var category in CategoryList.Where(x => x.ShopId == CurrentShop.Id))
                {
                    var button = new Button
                    {
                        Text = category.Title,
                        Tag = category.Id,
                        Size = new Size(100, 100),
                        Parent = flowLayoutPanelActualList
                    };
                    button.Click += buttonCategory_Click;
                }

                return;
            }

            flowLayoutPanelActualList.Controls.Clear();
            foreach (var shop in ShopList)
            {
                var button = new Button
                {
                    Text = shop.Title,
                    Tag = shop.Id,
                    Size = new Size(100, 100),
                    Parent = flowLayoutPanelActualList
                };
                button.Click += buttonShop_Click;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StopListForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelFullname.Text = CurrentUser.User.Fullname;
            toolStripStatusLabelRole.Text = CurrentUser.User.Role.Title;

            using (var db = new RestManDbContext())
            {
                comboBoxShops.Items.Clear();
                comboBoxShops.Items.AddRange(db.Shops.ToArray());
                comboBoxShops.Items.Insert(0, new Shop()
                {
                    Id = -1,
                    Title = "Все цеха",
                });
                comboBoxShops.DisplayMember = nameof(Shop.Title);
                comboBoxShops.SelectedIndex = 0;
            }
        }

        private void dataGridViewStopList_SelectionChanged(object sender, EventArgs e)
        {
            buttonDeleteFromStopList.Visible = dataGridViewStopList.SelectedRows.Count > 0;
        }

        private void buttonDeleteFromStopList_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewStopList.SelectedRows;

            var element = selectedRows.Count > 1
                ? selectedRows.Count.ToString()
                : ((Context.Models.MenuItem)selectedRows[0].DataBoundItem).Title;

            if (MessageBox.Show($"Вы уверены, что хотите убрать элементы: {element}\n" +
                $"из стоп-листа?",
                "Подтвердите действие",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new RestManDbContext())
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        var menuItem = row.DataBoundItem as Context.Models.MenuItem;
                        var menuItemDb = db.MenuItems.FirstOrDefault(x => x.Id == menuItem.Id);

                        menuItemDb.IsStopListed = false;
                    }

                    db.SaveChanges();
                }

                StopListFilter();
                ActualListHandler();
            }
        }

        private void textBoxActualListSearch_TextChanged(object sender, EventArgs e)
        {
            ActualListHandler();
        }

        private void StopListFilter()
        {
            var shopId = ((Shop)comboBoxShops.SelectedItem).Id;
            var categoryId = (Category)comboBoxCategories.SelectedItem == null
                ? -1
                : ((Category)comboBoxCategories.SelectedItem).Id;
            using (var db = new RestManDbContext())
            {
                dataGridViewStopList.DataSource = db.MenuItems
                                                .Where(x => x.IsStopListed == true
                                                        && (x.CategoryId == categoryId
                                                            || categoryId == -1
                                                                && (x.Category.ShopId == shopId
                                                                    || shopId == -1))
                                                        && x.Title.Contains(textBoxStopListSearch.Text))
                                                .OrderBy(x => x.Title)
                                                .ToList();
            }
        }

        private void textBoxStopListSearch_TextChanged(object sender, EventArgs e)
        {
            StopListFilter();
        }

        private void comboBoxShops_SelectedIndexChanged(object sender, EventArgs e)
        {
            var shopId = ((Shop)comboBoxShops.SelectedItem).Id;

            if (labelCategory.Visible = comboBoxCategories.Visible = shopId != -1)
            {
                using (var db = new RestManDbContext())
                {
                    comboBoxCategories.Items.Clear();
                    comboBoxCategories.Items.AddRange(db.Categories
                        .Where(x => x.ShopId == shopId)
                        .ToArray());
                    comboBoxCategories.Items.Insert(0, new Category()
                    {
                        Id = -1,
                        Title = "Все категории",
                    });
                    comboBoxCategories.DisplayMember = nameof(Category.Title);
                    comboBoxCategories.SelectedIndex = 0;
                }
            }

            StopListFilter();
        }

        private void AddBackButton()
        {
            var buttonBack = new Button
            {
                Text = "Назад",
                Size = new Size(100, 100),
                Parent = flowLayoutPanelActualList
            };
            buttonBack.Click += buttonBack_Click;
        }
    }
}
