using RestMan.Context;
using RestMan.Context.Models;
using System;
using System.Data;
using System.Linq;
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

                    var users = db.Users.Where(x => x.IsOnShift == true);

                    foreach (User u in users)
                    {
                        u.IsOnShift = false;
                    }

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

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var changePasswordForm = new AuthForm(false);
            changePasswordForm.ShowDialog();
        }

        private void finishShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                var user = db.Users.FirstOrDefault(x => x.Id == CurrentUser.User.Id);

                user.IsOnShift = false;
                db.SaveChanges();
            }

            this.Close();
        }

        private void buttonDatabaseAccess_Click(object sender, EventArgs e)
        {

        }
    }
}
