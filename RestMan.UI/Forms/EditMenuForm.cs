using RestMan.Context;
using RestMan.Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuItem = RestMan.Context.Models.MenuItem;

namespace RestMan.UI.Forms
{
    public partial class EditMenuForm : Form
    {
        private bool isNewShop = false;
        private bool isNewCategory = false;
        private MenuItem backupMenuItem;
        public MenuItem MenuItem { get; set; }
        public EditMenuForm()
        {
            InitializeComponent();
            this.MenuItem = new MenuItem()
            {
                Id = -1,
            };
        }

        public EditMenuForm(MenuItem menuItem)
        {
            InitializeComponent();
            this.MenuItem = menuItem;
            this.backupMenuItem = new MenuItem()
            {
                Id = -1,
                Title = menuItem.Title,
                CategoryId = menuItem.CategoryId,
            };
            this.Text = "Изменение позиции";
        }

        private void EditMenuForm_Load(object sender, EventArgs e)
        {
            FillShops();

            if (MenuItem.Id != -1)
            {
                comboBoxShop.SelectedItem = comboBoxShop.Items.Cast<Shop>().FirstOrDefault(x => x.Id == MenuItem.Category.ShopId);
                comboBoxCategory.SelectedItem = comboBoxCategory.Items.Cast<Category>().FirstOrDefault(x => x.Id == MenuItem.CategoryId);
                textBoxTitle.Text = MenuItem.Title;
                numericUpDownCost.Value = MenuItem.Cost;
            }    
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (comboBoxShop.SelectedItem == null)
            {
                if (MessageBox.Show($"Вы хотите создать новый цех:\n{comboBoxShop.Text}?",
                    "Подтвердите действие",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    comboBoxShop.Text = string.Empty;
                    return;
                }

                isNewShop = true;
            }

            if (comboBoxCategory.SelectedItem == null)
            {
                if (MessageBox.Show($"Вы хотите создать новую категорию:\n{comboBoxCategory.Text}?",
                    "Подтвердите действие",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    comboBoxCategory.Text = string.Empty;
                    return;
                }

                isNewCategory = true;
            }

            var shop = (Shop)comboBoxShop.SelectedItem ?? new Shop() { Title = comboBoxShop.Text };
            var category = (Category)comboBoxCategory.SelectedItem ?? new Category() { Title = comboBoxCategory.Text };

            using (var db = new RestManDbContext())
            {
                var shopDB = db.Shops.FirstOrDefault(x => x.Id == shop.Id);
                var categoryDB = db.Categories.FirstOrDefault(x => x.Id == category.Id);

                if (isNewShop)
                {
                    db.Shops.Add(shop);
                    db.SaveChanges();
                    shopDB = db.Shops.ToList().LastOrDefault(x => x.Title == shop.Title);
                }

                category.ShopId = shopDB.Id;

                if (isNewCategory)
                {
                    db.Categories.Add(category);
                    db.SaveChanges();
                    categoryDB = db.Categories.ToList().LastOrDefault(x => x.Title == category.Title);
                }


                this.MenuItem.Title = textBoxTitle.Text;
                this.MenuItem.Cost = int.Parse(numericUpDownCost.Value.ToString());
                this.MenuItem.CategoryId = categoryDB.Id;

                var uniqueItem = db.MenuItems.FirstOrDefault(x => x.Title == MenuItem.Title);

                if (this.MenuItem.Id == -1)
                {
                    if (uniqueItem != null && uniqueItem.CategoryId == MenuItem.CategoryId)
                    {
                        MessageBox.Show("Такая позиция уже существует",
                                        "Ошибка",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Stop);
                        return;
                    }

                    db.MenuItems.Add(this.MenuItem);
                }
                else
                {
                    if ((backupMenuItem.Title != MenuItem.Title
                        || backupMenuItem.CategoryId != MenuItem.CategoryId)
                        && uniqueItem != null
                        && uniqueItem.CategoryId == MenuItem.CategoryId)
                    {
                        MessageBox.Show("Такая позиция уже существует",
                                        "Ошибка",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Stop);
                        return;
                    }

                    var menuItemDB = db.MenuItems.FirstOrDefault(x => x.Id == this.MenuItem.Id);

                    menuItemDB.Title = this.MenuItem.Title;
                    menuItemDB.Cost = this.MenuItem.Cost;
                    menuItemDB.CategoryId = this.MenuItem.CategoryId;
                }

                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
        }

        private void comboBoxShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender.Equals(comboBoxShop))
            {
                FillCategories();
            }

            buttonOk.Enabled = !string.IsNullOrWhiteSpace(comboBoxShop.Text)
                               && !string.IsNullOrWhiteSpace(comboBoxCategory.Text)
                               && !string.IsNullOrWhiteSpace(textBoxTitle.Text);
        }

        private void FillCategories()
        {
            var shopId = ((Shop)comboBoxShop.SelectedItem)?.Id;

            comboBoxCategory.Items.Clear();
            comboBoxCategory.Text = string.Empty;

            if (comboBoxCategory.Enabled = shopId != -1)
            {
                using (var db = new RestManDbContext())
                {
                    comboBoxCategory.Items.AddRange(db.Categories
                        .Where(x => x.ShopId == shopId)
                        .ToArray());
                    comboBoxCategory.DisplayMember = nameof(Category.Title);
                    if (comboBoxCategory.Items.Count > 0)
                    {
                        comboBoxCategory.SelectedIndex = 0;
                    }
                }
            }
        }

        private void FillShops()
        {
            using (var db = new RestManDbContext())
            {
                comboBoxShop.Items.Clear();
                comboBoxShop.Items.AddRange(db.Shops.ToArray());
                comboBoxShop.DisplayMember = nameof(Shop.Title);
                comboBoxShop.SelectedIndex = 0;
            }
        }

        private void comboBoxShop_Leave(object sender, EventArgs e)
        {
            var shop = comboBoxShop.Items.Cast<Shop>().FirstOrDefault(x => x.Title.ToLower() == comboBoxShop.Text.ToLower());

            if (shop != null)
            {
                comboBoxShop.SelectedItem = shop;
            }
        }

        private void comboBoxCategory_Leave(object sender, EventArgs e)
        {
            var category = comboBoxCategory.Items.Cast<Category>().FirstOrDefault(x => x.Title.ToLower() == comboBoxCategory.Text.ToLower());

            if (category != null)
            {
                comboBoxCategory.SelectedItem = category;
            }
        }

        private void comboBoxShop_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxShop.SelectedItem = null;
        }
    }
}
