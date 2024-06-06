using RestMan.Context;
using RestMan.Context.Models;
using RestMan.UI.StaticClasses;
using RestMan.UI.UserControls;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RestMan.UI.Forms
{
    public partial class ReportsForm : Form
    {
        private Size controlSize = new Size(120, 120);
        private int roleId = -1;

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            if (ParentForm != null)
            {
                this.WindowState = ParentForm.WindowState;
            }

            toolStripStatusLabelFullname.Text = CurrentUser.User.Fullname;
            toolStripStatusLabelRole.Text = CurrentUser.User.Role.Title;

            FillControls();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillControls()
        {
            flowLayoutPanelControls.Controls.Clear();
            panelReport.Controls.Clear();

            new Button
            {
                Text = "Выручка по официантам",
                Size = controlSize,
                Parent = flowLayoutPanelControls
            }
            .Click += buttonWaiters_Click;

            new Button
            {
                Text = "Выручка по кассирам",
                Size = controlSize,
                Parent = flowLayoutPanelControls
            }
            .Click += buttonCashiers_Click;

            new Button
            {
                Text = "Выручка по менеджерам",
                Size = controlSize,
                Parent = flowLayoutPanelControls
            }
            .Click += buttonManagers_Click;

            new Button
            {
                Text = "Общая выручка",
                Size = controlSize,
                Parent = flowLayoutPanelControls
            }
            .Click += buttonCommon_Click;
        }

        private void buttonCommon_Click(object sender, EventArgs e)
        {
            panelReport.Controls.Clear();
            flowLayoutPanelControls.Controls.Clear();

            AddBackButton();

            using (var db = new RestManDbContext())
            {
                var user = new User()
                {
                    Id = -1,
                    Fullname = "Общая выручка",
                };

                var reportView = new ReportView(user)
                {
                    Parent = panelReport,
                    Dock = DockStyle.Top,
                };
            }

            groupBoxSearch.Enabled = false;
        }

        private void buttonManagers_Click(object sender, EventArgs e)
        {
            flowLayoutPanelControls.Controls.Clear();

            AddBackButton();

            using (var db = new RestManDbContext())
            {
                var orders = db.Orders.Where(x => x.ShiftId == CurrentShift.Shift.Id)
                                      .Select(x => x.WaiterId)
                                      .ToList();

                var managers = db.Users.Where(x => x.RoleId == 3
                                                   && (orders.Contains(x.Id)
                                                       || x.IsOnShift == true))
                                       .OrderBy(x => x.Fullname);

                foreach (var manager in managers)
                {
                    new Button
                    {
                        Text = manager.Fullname,
                        Tag = manager.Id,
                        Size = controlSize,
                        Parent = flowLayoutPanelControls
                    }
                    .Click += buttonReport_Click;
                }
            }

            roleId = 3;
            groupBoxSearch.Text = "Поиск по менеджерам";
        }

        private void buttonCashiers_Click(object sender, EventArgs e)
        {
            flowLayoutPanelControls.Controls.Clear();

            AddBackButton();

            using (var db = new RestManDbContext())
            {
                var orders = db.Orders.Where(x => x.ShiftId == CurrentShift.Shift.Id)
                                      .Select(x => x.WaiterId)
                                      .ToList();

                var cashiers = db.Users.Where(x => x.RoleId == 2
                                                   && (orders.Contains(x.Id)
                                                       || x.IsOnShift == true))
                                       .OrderBy(x => x.Fullname);

                foreach (var cashier in cashiers)
                {
                    new Button
                    {
                        Text = cashier.Fullname,
                        Tag = cashier.Id,
                        Size = controlSize,
                        Parent = flowLayoutPanelControls
                    }
                    .Click += buttonReport_Click;
                }
            }

            roleId = 2;

            groupBoxSearch.Text = "Поиск по кассирам";
        }

        private void buttonWaiters_Click(object sender, EventArgs e)
        {
            flowLayoutPanelControls.Controls.Clear();

            AddBackButton();

            using (var db = new RestManDbContext())
            {
                var orders = db.Orders.Where(x => x.ShiftId == CurrentShift.Shift.Id)
                                      .Select(x => x.WaiterId)
                                      .ToList();

                var waiters = db.Users.Where(x => x.RoleId == 1
                                                   && (orders.Contains(x.Id)
                                                       || x.IsOnShift == true))
                                       .OrderBy(x => x.Fullname);

                foreach (var waiter in waiters)
                {
                    new Button
                    {
                        Text = waiter.Fullname,
                        Tag = waiter.Id,
                        Size = controlSize,
                        Parent = flowLayoutPanelControls
                    }
                    .Click += buttonReport_Click;
                }
            }

            roleId = 1;

            groupBoxSearch.Text = "Поиск по официантам";
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            panelReport.Controls.Clear();

            using (var db = new RestManDbContext())
            {
                int.TryParse(((Button)sender).Tag.ToString(), out var id);

                var user = db.Users.FirstOrDefault(x => x.Id == id);

                var reportView = new ReportView(user)
                {
                    Parent = panelReport,
                    Dock = DockStyle.Top,
                };
            }
        }

        private void AddBackButton()
        {
            var size = new Size(120, 120);

            new Button
            {
                Text = "Назад",
                Size = size,
                Parent = flowLayoutPanelControls
            }
            .Click += buttonBack_Click;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FillControls();
            roleId = -1;

            groupBoxSearch.Text = "Поиск";
            groupBoxSearch.Enabled = true;
        }

        private void fullReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillControls();
            using (var db = new RestManDbContext())
            {
                var userCommon = new User()
                {
                    Id = -1,
                    Fullname = "Общая выручка",
                };

                var reportViewCommon = new ReportView(userCommon)
                {
                    Parent = panelReport,
                    Dock = DockStyle.Top,
                };

                var orders = db.Orders.Where(x => x.ShiftId == CurrentShift.Shift.Id)
                                      .Select(x => x.WaiterId)
                                      .ToList();

                var users = db.Users.Include(x => x.Role).Where(x => (orders.Contains(x.Id)
                                                       || x.IsOnShift == true)
                                                && x.RoleId != 4)
                                    .OrderByDescending(x => x.RoleId);

                foreach (var user in users)
                {
                    var reportView = new ReportView(user)
                    {
                        Parent = panelReport,
                        Dock = DockStyle.Top,
                    };
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanelControls.Controls.Clear();
            panelReport.Controls.Clear();

            if (textBoxSearch.TextLength == 0)
            {
                FillControls();

                return;
            }

            using (var db = new RestManDbContext())
            {
                var orders = db.Orders.Where(x => x.ShiftId == CurrentShift.Shift.Id)
                                      .Select(x => x.WaiterId)
                                      .ToList();

                var users = db.Users.Where(x => (orders.Contains(x.Id)
                                                       || x.IsOnShift == true)
                                                && (x.RoleId == roleId
                                                    || roleId == -1)
                                                && x.RoleId != 4
                                                && x.Fullname.ToLower().Contains(textBoxSearch.Text.ToLower()));

                foreach (var user in users)
                {
                    new Button
                    {
                        Text = user.Fullname,
                        Tag = user.Id,
                        Size = controlSize,
                        Parent = flowLayoutPanelControls
                    }
                    .Click += buttonReport_Click;
                }
            }
        }
    }
}
