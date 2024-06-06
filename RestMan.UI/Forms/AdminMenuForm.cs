using RestMan.Context;
using RestMan.Context.Models;
using RestMan.UI.StaticClasses;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RestMan.UI.Forms
{
    public partial class AdminMenuForm : Form
    {
        private Shop currentShop;
        private Category currentCategory;
        public AdminMenuForm()
        {
            InitializeComponent();
            dataGridViewMenu.AutoGenerateColumns = false;
            InitMenu();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {
            if (ParentForm != null)
            {
                this.WindowState = ParentForm.WindowState;
            }

            toolStripStatusLabelFullname.Text = CurrentUser.User.Fullname;
            toolStripStatusLabelRole.Text = CurrentUser.User.Role.Title;
            dataGridViewMenu.ClearSelection();

            FillShops();
        }

        private void InitMenu()
        {
            using (var db = new RestManDbContext())
            {
                dataGridViewMenu.DataSource = db.MenuItems
                                              .Include(x => x.Category)
                                              .Include(x => x.Category.Shop)
                                              .Select(x => new
                                              {
                                                  Id = x.Id,
                                                  Title = x.Title,
                                                  Cost = x.Cost,
                                                  Shop = x.Category.Shop.Title,
                                                  Category = x.Category.Title,
                                              })
                                              .OrderBy(x => x.Title)
                                              .ToList();
            }
        }

        private void FillShops()
        {
            using (var db = new RestManDbContext())
            {
                comboBoxShop.Items.Clear();
                comboBoxShop.Items.AddRange(db.Shops.ToArray());
                comboBoxShop.Items.Insert(0, new Shop()
                {
                    Id = -1,
                    Title = "Все цеха",
                });
                comboBoxShop.DisplayMember = nameof(Shop.Title);
                comboBoxShop.SelectedItem = comboBoxShop.Items
                                                        .Cast<Shop>()
                                                        .FirstOrDefault(x => currentShop == null
                                                                             || x.Id == currentShop.Id);
            }
        }

        private void FillCategories()
        {
            var shopId = ((Shop)comboBoxShop.SelectedItem).Id;

            comboBoxCategory.Items.Clear();

            if (labelCategory.Visible = comboBoxCategory.Visible = shopId != -1)
            {
                using (var db = new RestManDbContext())
                {
                    comboBoxCategory.Items.AddRange(db.Categories
                        .Where(x => x.ShopId == shopId)
                        .ToArray());
                    comboBoxCategory.Items.Insert(0, new Category()
                    {
                        Id = -1,
                        Title = "Все категории",
                    });
                    comboBoxCategory.DisplayMember = nameof(Category.Title);
                    comboBoxCategory.SelectedItem = comboBoxCategory.Items
                                                                    .Cast<Category>()
                                                                    .FirstOrDefault(x => currentCategory == null
                                                                                                || x.Id == currentCategory.Id);
                }
            }
        }

        private void Filter()
        {
            var shopId = ((Shop)comboBoxShop.SelectedItem).Id;
            var categoryId = (Category)comboBoxCategory.SelectedItem == null
                ? -1
                : ((Category)comboBoxCategory.SelectedItem).Id;
            var searchText = string.IsNullOrWhiteSpace(textBoxSearch.Text)
                ? ""
                : textBoxSearch.Text.ToLower();

            using (var db = new RestManDbContext())
            {
                dataGridViewMenu.DataSource = db.MenuItems
                                                .Include(x => x.Category)
                                                .Include(x => x.Category.Shop)
                                                .Where(x => (x.CategoryId == categoryId
                                                            || categoryId == -1)
                                                                && (x.Category.ShopId == shopId
                                                                    || shopId == -1)
                                                        && x.Title.ToLower().Contains(searchText))
                                                .Select(x => new
                                                {
                                                    Id = x.Id,
                                                    Title = x.Title,
                                                    Cost = x.Cost,
                                                    Shop = x.Category.Shop.Title,
                                                    Category = x.Category.Title,
                                                })
                                                .OrderBy(x => x.Title)
                                                .ToList();
            }

            dataGridViewMenu.ClearSelection();
        }

        private void comboBoxShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCategory = null;

            FillCategories();
            Filter();

            currentShop = (Shop)comboBoxShop.SelectedItem;

            buttonDeleteShop.Visible = currentShop.Id != -1;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();

            currentCategory = (Category)comboBoxCategory.SelectedItem;

            buttonDeleteCategory.Visible = currentCategory.Id != -1;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var editMenuForm = new EditMenuForm();

            if (editMenuForm.ShowDialog() == DialogResult.OK)
            {
                Filter();
                FillShops();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                var selectedRow = dataGridViewMenu.SelectedRows[0];
                var rowIndex = selectedRow.Index;

                int.TryParse(selectedRow.Cells["ColumnId"].Value.ToString(), out var id);

                var menuItem = db.MenuItems
                    .Include(x => x.Category)
                    .Include(x => x.Category.Shop)
                    .FirstOrDefault(x => x.Id == id);

                if (menuItem == null)
                {
                    return;
                }

                var editMenuForm = new EditMenuForm(menuItem);

                if (editMenuForm.ShowDialog() == DialogResult.OK)
                {
                    Filter();

                    if (rowIndex <= dataGridViewMenu.RowCount
                        && dataGridViewMenu.RowCount > 0
                        && rowIndex >= 0)
                    {
                        dataGridViewMenu.Rows[rowIndex].Selected = true;
                        dataGridViewMenu.FirstDisplayedScrollingRowIndex = rowIndex;
                    }

                    FillShops();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var menuItems = dataGridViewMenu.SelectedRows;
            var rowIndex = menuItems[0].Index - 1;

            var ending = "";

            if (menuItems.Count == 1)
            {
                ending = "ю:\n" + menuItems[0].Cells["ColumnTitle"].Value.ToString();
            }

            if (menuItems.Count > 1)
            {
                ending = "и: " + menuItems.Count;
            }

            if (MessageBox.Show($"Вы уверены, что хотите удалить позици{ending}?", "Подтвердите действие",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (var db = new RestManDbContext())
                {
                    foreach (DataGridViewRow menuItem in menuItems)
                    {
                        int.TryParse(menuItem.Cells["ColumnId"].Value.ToString(), out var id);

                        var menuItemDb = db.MenuItems.FirstOrDefault(x => x.Id == id);

                        db.MenuItems.Remove(menuItemDb);

                        db.SaveChanges();
                    }
                }

                Filter();

                if (rowIndex >= 0)
                {
                    dataGridViewMenu.FirstDisplayedScrollingRowIndex = rowIndex;
                }
            }
        }

        private void buttonDeleteShop_Click(object sender, EventArgs e)
        {
            var shop = (Shop)comboBoxShop.SelectedItem;

            if (MessageBox.Show($"Вы уверены, что хотите удалить цех:\n{shop.Title}?",
                "Подтвердите действие",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (var db = new RestManDbContext())
                {
                    var shopDB = db.Shops.FirstOrDefault(x => x.Id == shop.Id);

                    db.Shops.Remove(shopDB);
                    db.SaveChanges();
                }

                Filter();
            }

            currentShop = null;

            FillShops();
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            var category = (Category)comboBoxCategory.SelectedItem;

            if (MessageBox.Show($"Вы уверены, что хотите удалить категорию:\n{category.Title}?",
                "Подтвердите действие",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (var db = new RestManDbContext())
                {
                    var categoryDB = db.Categories.FirstOrDefault(x => x.Id == category.Id);

                    db.Categories.Remove(categoryDB);
                    db.SaveChanges();
                }

                Filter();
            }

            currentCategory = null;

            FillCategories();
        }

        private void dataGridViewMenu_SelectionChanged(object sender, EventArgs e)
        {
            buttonEdit.Enabled = dataGridViewMenu.SelectedRows.Count == 1;
            buttonDelete.Enabled = dataGridViewMenu.SelectedRows.Count > 0;
        }

        private void comboBoxCategory_VisibleChanged(object sender, EventArgs e)
        {
            buttonDeleteCategory.Visible = comboBoxCategory.Visible;
        }
    }
}
