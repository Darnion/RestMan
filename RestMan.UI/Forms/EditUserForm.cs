using RestMan.Context;
using RestMan.Context.Models;
using RestMan.UI.Common;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RestMan.UI.Forms
{
    public partial class EditUserForm : Form
    {
        public User User { get; set; }
        public EditUserForm()
        {
            InitializeComponent();
        }

        public EditUserForm(User user)
        {
            InitializeComponent();
            this.User = user;
            this.Text = "Изменение пользователя";
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z\d\b]"))
            {
                e.Handled = true;
            }
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            FillRoles();

            if (this.User != null)
            {
                textBoxFullname.Text = User.Fullname;
                textBoxLogin.Text = User.Login;
                textBoxPassword.Text = "скрыто";
                textBoxPassword.Enabled = false;
                comboBoxRole.SelectedItem = comboBoxRole.Items.Cast<Role>().FirstOrDefault(x => x.Id == this.User.RoleId);
                return;
            }

            this.User = new User()
            {
                Id = -1,
            };
        }

        private void FillRoles()
        {
            using (var db = new RestManDbContext())
            {
                comboBoxRole.Items.Clear();
                comboBoxRole.Items.AddRange(db.Roles.Where(x => x.Id != 4).ToArray());
                comboBoxRole.DisplayMember = nameof(Role.Title);
                comboBoxRole.SelectedIndex = 0;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxLogin.Text,
                @"^[a-zA-Z\d]{3,15}$"))
            {
                var tooltip = new ToolTip();

                tooltip.SetToolTip(textBoxLogin, "");
                tooltip.ToolTipTitle = "Логин должен состоять из:";
                tooltip.Show("- строчных и прописных латинских букв\n" +
                             "- цифр\n" +
                             "- от 3 до 15 символов\n"
                             , textBoxLogin, 2000);
                return;
            }

            if (!Regex.IsMatch(textBoxPassword.Text,
                "^[a-zA-Z\\d-_.+=<>@#$%^*()\\/&!?]{3,15}$")
                && textBoxPassword.Text != "скрыто")
            {
                var tooltip = new ToolTip();

                tooltip.SetToolTip(textBoxPassword, "");
                tooltip.ToolTipTitle = "Пароль должен состоять из:";
                tooltip.Show("- строчных и прописных латинских букв\n" +
                             "- цифр\n" +
                             "- специальных символов\n" +
                             "- от 3 до 15 символов\n"
                             , textBoxPassword, 2000);
                return;
            }

            if (this.User.Id == -1)
            {
                var authorizator = new Authorizator();
                var salt = authorizator.CreateSalt(16);
                var hashPassword = authorizator.GenerateSHA256Hash(textBoxPassword.Text, salt);

                this.User.Password = hashPassword;
                this.User.Salt = salt;
            }

            this.User.Fullname = textBoxFullname.Text;
            this.User.Login = textBoxLogin.Text;
            this.User.RoleId = ((Role)comboBoxRole.SelectedItem).Id;

            DialogResult = DialogResult.OK;
        }

        private void textBoxFullname_TextChanged(object sender, EventArgs e)
        {
            buttonOk.Enabled = !string.IsNullOrEmpty(textBoxFullname.Text)
                                && !string.IsNullOrEmpty(textBoxLogin.Text)
                                && !string.IsNullOrEmpty(textBoxPassword.Text)
                                && comboBoxRole.SelectedItem != null;
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z\d\b-_.+=<>@#$%^*()\\/&!?]")
                || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
