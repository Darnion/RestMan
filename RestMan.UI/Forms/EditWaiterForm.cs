using RestMan.Context;
using RestMan.Context.Models;
using RestMan.UI.StaticClasses;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RestMan.UI.Forms
{
    public partial class EditWaiterForm : Form
    {
        public User Waiter { get; set; }
        public EditWaiterForm()
        {
            InitializeComponent();
        }

        private void EditWaiterForm_Load(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                var orders = db.Orders.Where(x => x.ShiftId == CurrentShift.Shift.Id)
                      .Select(x => x.WaiterId)
                      .ToList();

                comboBoxWaiter.DataSource = db.Users
                    .Where(x => (x.RoleId == 1 || x.RoleId == 2 || x.RoleId == 3)
                                && (x.Id == Waiter.Id
                                    || x.IsOnShift == true))
                    .ToArray();

                comboBoxWaiter.DisplayMember = nameof(User.Fullname);
                comboBoxWaiter.SelectedItem = comboBoxWaiter.Items
                    .Cast<User>()
                    .FirstOrDefault(x => x.Id == Waiter.Id);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Waiter = (User)comboBoxWaiter.SelectedItem;
        }

        private void Filter()
        {
            var searchText = textBoxSearch.Text.ToLower() ?? string.Empty;

            using (var db = new RestManDbContext())
            {
                var orders = db.Orders.Where(x => x.ShiftId == CurrentShift.Shift.Id)
                      .Select(x => x.WaiterId)
                      .ToList();

                comboBoxWaiter.DataSource = db.Users
                    .Where(x => (x.RoleId == 1 || x.RoleId == 2 || x.RoleId == 3)
                                && (x.Id == Waiter.Id
                                    || x.IsOnShift == true)
                                && x.Fullname.ToLower().Contains(searchText))
                    .ToArray();

                comboBoxWaiter.DisplayMember = nameof(User.Fullname);
                comboBoxWaiter.SelectedItem = comboBoxWaiter.Items
                    .Cast<User>()
                    .FirstOrDefault(x => x.Id == Waiter.Id);

                if (comboBoxWaiter.SelectedItem == null && comboBoxWaiter.Items.Count > 0)
                {
                    comboBoxWaiter.SelectedIndex = 0;
                }
            }

            buttonOk.Enabled = comboBoxWaiter.Items.Count > 0;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void groupBoxSearch_Enter(object sender, EventArgs e)
        {

        }
    }
}
