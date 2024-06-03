using RestMan.Context;
using RestMan.Context.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RestMan.UI.Forms
{
    public partial class MainForm : Form
    {
        private List<Control> controls = new List<Control>();
        private List<Control> tempControls = new List<Control>();
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

            controls.Clear();

            var button = new Button()
            {
                Size = new Size(272, 46),
                Dock = DockStyle.Top,
                Text = "Пользователи",
            };
            button.Click += buttonEditUsers_Click;
            controls.Add(button);

            button = new Button()
            {
                Size = new Size(272, 46),
                Dock = DockStyle.Top,
                Text = "Столы",
            };
            button.Click += buttonEditTables_Click;
            controls.Add(button);

            button = new Button()
            {
                Size = new Size(272, 46),
                Dock = DockStyle.Top,
                Text = "Меню",
            };
            button.Click += buttonEditMenu_Click;
            controls.Add(button);

            button = new Button()
            {
                Size = new Size(272, 46),
                Dock = DockStyle.Top,
                Text = "Назад"
            };
            button.Click += buttonDatabaseAccess_Click;
            controls.Add(button);
        }

        private void buttonEditUsers_Click(object sender, EventArgs e)
        {
            var adminUsersForm = new AdminUsersForm();
            this.Hide();
            adminUsersForm.ShowDialog();
            this.Show();
        }

        private void buttonEditMenu_Click(object sender, EventArgs e)
        {
            var adminMenuForm = new AdminMenuForm();
            this.Hide();
            adminMenuForm.ShowDialog();
            this.Show();
        }
        private void buttonEditTables_Click(object sender, EventArgs e)
        {
            var adminTablesForm = new AdminTablesForm();
            this.Hide();
            adminTablesForm.ShowDialog();
            this.Show();
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
            tempControls.Clear();
            foreach (Control control in panelControls.Controls)
            {
                tempControls.Add(control);
            }

            panelControls.Controls.Clear();

            panelControls.Controls.AddRange(controls.ToArray());

            controls.Clear();
            foreach (Control control in tempControls)
            {
                controls.Add(control);
            }
        }
    }
}
