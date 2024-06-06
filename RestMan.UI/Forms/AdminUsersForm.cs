using RestMan.Context;
using RestMan.Context.Models;
using RestMan.UI.StaticClasses;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RestMan.UI.Forms
{
    public partial class AdminUsersForm : Form
    {
        private Role sortedRole;
        private string searchText;
        public AdminUsersForm()
        {
            InitializeComponent();
            dataGridViewUsers.AutoGenerateColumns = false;
            InitUsers();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminUsersForm_Load(object sender, EventArgs e)
        {
            if (ParentForm != null)
            {
                this.WindowState = ParentForm.WindowState;
            }

            toolStripStatusLabelFullname.Text = CurrentUser.User.Fullname;
            toolStripStatusLabelRole.Text = CurrentUser.User.Role.Title;
            dataGridViewUsers.ClearSelection();

            FillRoles();
        }

        private void InitUsers()
        {
            using (var db = new RestManDbContext())
            {
                dataGridViewUsers.DataSource = db.Users.Select(x => new
                {
                    Fullname = x.Fullname,
                    Login = x.Login,
                    Role = x.Role.Title,
                })
                    .OrderBy(x => x.Fullname)
                    .ToList();
            }
        }

        private void FillRoles()
        {
            using (var db = new RestManDbContext())
            {
                comboBoxRole.Items.Clear();
                comboBoxRole.Items.AddRange(db.Roles.Where(x => x.Id != 4).ToArray());
                comboBoxRole.Items.Insert(0, new Role()
                {
                    Id = -1,
                    Title = "Все роли"
                });
                comboBoxRole.DisplayMember = nameof(Role.Title);
                comboBoxRole.SelectedIndex = 0;
            }
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchText = string.IsNullOrWhiteSpace(textBoxSearch.Text)
                ? ""
                : textBoxSearch.Text.ToLower();
            sortedRole = (Role)comboBoxRole.SelectedItem;

            Filter();
        }

        private void Filter()
        {
            using (var db = new RestManDbContext())
            {
                dataGridViewUsers.DataSource = db.Users.Where(x => x.Id != CurrentUser.User.Id
                                                        && (x.RoleId == sortedRole.Id
                                                            || sortedRole.Id == -1)
                                                        && (x.Fullname.ToLower().Contains(searchText)
                                                            || x.Login.Contains(searchText)))
                                                       .Select(x => new
                                                       {
                                                           Id = x.Id,
                                                           Fullname = x.Fullname,
                                                           Login = x.Login,
                                                           Role = x.Role.Title,
                                                       })
                                                       .OrderBy(x => x.Fullname)
                                                       .ToList();
            }

            dataGridViewUsers.ClearSelection();
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            buttonEdit.Enabled = dataGridViewUsers.SelectedRows.Count == 1;
            buttonDelete.Enabled = dataGridViewUsers.SelectedRows.Count > 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var editUserForm = new EditUserForm();

            if (editUserForm.ShowDialog() == DialogResult.OK)
            {
                using (var db = new RestManDbContext())
                {
                    db.Users.Add(editUserForm.User);

                    db.SaveChanges();
                };

                Filter();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                var selectedRow = dataGridViewUsers.SelectedRows[0];
                var rowIndex = selectedRow.Index;

                int.TryParse(selectedRow.Cells["ColumnId"].Value.ToString(), out var id);

                var userDB = db.Users.Include(x => x.Role).FirstOrDefault(x => x.Id == id);

                if (userDB == null)
                {
                    return;
                }

                var editUserForm = new EditUserForm(userDB);

                if (editUserForm.ShowDialog() == DialogResult.OK)
                {
                    var formUser = editUserForm.User;

                    userDB.Fullname = formUser.Fullname;
                    userDB.Login = formUser.Login;
                    userDB.RoleId = formUser.RoleId;

                    db.SaveChanges();

                    Filter();

                    dataGridViewUsers.Rows[rowIndex].Selected = true;
                    dataGridViewUsers.FirstDisplayedScrollingRowIndex = rowIndex;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var users = dataGridViewUsers.SelectedRows;
            var rowIndex = users[0].Index - 1;

            var ending = "";

            if (users.Count == 1)
            {
                ending = "я:\n" + users[0].Cells["ColumnFullname"].Value.ToString();
            }

            if (users.Count > 1)
            {
                ending = "ей: " + users.Count;
            }

            if (MessageBox.Show($"Вы уверены, что хотите удалить пользовател{ending}?", "Подтвердите действие",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (var db = new RestManDbContext())
                {
                    foreach (DataGridViewRow user in users)
                    {
                        int.TryParse(user.Cells["ColumnId"].Value.ToString(), out var id);

                        var userDB = db.Users.FirstOrDefault(x => x.Id == id);

                        db.Users.Remove(userDB);

                        db.SaveChanges();
                    }
                }

                Filter();

                dataGridViewUsers.FirstDisplayedScrollingRowIndex = rowIndex;
            }
        }
    }
}
