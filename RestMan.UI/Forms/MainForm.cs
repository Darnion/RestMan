using RestMan.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestMan.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menuStrip.Items.Add(new ToolStripSeparator()
            {
                Alignment = ToolStripItemAlignment.Right
            });

            toolStripStatusLabelFullname.Text = CurrentUser.User.Fullname;
            toolStripStatusLabelRole.Text = CurrentUser.User.Role.Title;

            buttonOrders.Visible = CurrentUser.IsWaiter()
                                   || CurrentUser.IsCashier()
                                   || CurrentUser.IsManager();
            buttonClosedOrders.Visible = CurrentUser.IsCashier() || CurrentUser.IsManager();
            buttonStopList.Visible = buttonReports.Visible = buttonCloseShift.Visible = CurrentUser.IsManager();
            buttonDatabaseAccess.Visible = CurrentUser.IsAdmin();
        }

        private void buttonCloseShift_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите закрыть смену?\n" +
                "Это действие необратимо!", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (var db = new RestManDbContext())
                {
                    var shift = db.Shifts.SingleOrDefault(x => x.Id == CurrentShift.Shift.Id);
                    shift.ClosedAt = DateTime.Now;
                    db.SaveChanges();
                }

                this.Close();
            }
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            var ordersForm = new OrdersForm(true);
            this.Hide();
            ordersForm.ShowDialog();
            this.Show();
        }

        private void buttonClosedOrders_Click(object sender, EventArgs e)
        {
            var ordersForm = new OrdersForm(false);
            this.Hide();
            ordersForm.ShowDialog();
            this.Show();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            var reportsForm = new ReportsForm();
            this.Hide();
            reportsForm.ShowDialog();
            this.Show();
        }

        private void buttonStopList_Click(object sender, EventArgs e)
        {
            var stopListForm = new StopListForm();
            this.Hide();
            stopListForm.ShowDialog();
            this.Show();
        }
    }
}
