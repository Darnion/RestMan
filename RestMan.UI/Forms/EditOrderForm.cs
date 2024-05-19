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

namespace RestMan.UI.Forms
{
    public partial class EditOrderForm : Form
    {
        public Order Order { get; set; }
        public EditOrderForm(Order order)
        {
            InitializeComponent();
            this.Order = order;
            OrderMenuItemsHandler();
            OrderPaymentsHandler();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditOrderForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelFullname.Text = CurrentUser.User.Fullname;
            toolStripStatusLabelRole.Text = CurrentUser.User.Role.Title;

            panelControls.Visible = !Order.DeletedAt.HasValue;
            buttonEditWaiter.Visible = buttonCloseOrder.Visible = CurrentUser.IsCashier() || CurrentUser.IsManager();
            buttonEditOrderMenuItem.Visible = buttonDeleteOrderMenuItem.Visible = CurrentUser.IsManager();
        }

        private void OrderMenuItemsHandler()
        {
            using (var db = new RestManDbContext())
            {
                dataGridViewOrderMenuItems.DataSource = db.OrderMenuItems
                    .Include(x => x.Order)
                    .Include(x => x.MenuItem)
                    .ToList()
                    .Where(x => x.OrderId == this.Order.Id)
                    .Select(x => new
                    {
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
                
            }
        }

        private void dataGridViewOrderMenuItems_SelectionChanged(object sender, EventArgs e)
        {
            buttonEditOrderMenuItem.Enabled = dataGridViewOrderMenuItems.SelectedRows.Count == 1;
            buttonDeleteOrderMenuItem.Enabled = dataGridViewOrderMenuItems.SelectedRows.Count > 0;
        }
    }
}
