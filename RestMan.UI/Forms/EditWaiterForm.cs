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

namespace RestMan.UI.Forms
{
    public partial class EditWaiterForm : Form
    {
        public User Waiter;
        public EditWaiterForm(User waiter)
        {
            InitializeComponent();
            Waiter = waiter;
        }

        private void EditWaiterForm_Load(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                comboBoxWaiter.DataSource = db.Users
                    .Where(x => x.RoleId == 1 || x.RoleId == 2 || x.RoleId == 3)
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
    }
}
