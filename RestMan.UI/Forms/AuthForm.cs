using RestMan.Context;
using RestMan.Context.Models;
using RestMan.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestMan.UI.Forms
{
    public partial class AuthForm : Form
    {
        private bool isAuthForm = true;
        public AuthForm()
        {
            InitializeComponent();
        }

        public AuthForm(bool isAuthForm)
        {
            InitializeComponent();
            this.isAuthForm = isAuthForm;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (isAuthForm)
            {
                using (var db = new RestManDbContext())
                {
                    var user = db.Users.Include(x => x.Role)
                                       .FirstOrDefault(x => x.Login == textBoxLogin.Text);

                    if (user == null)
                    {
                        MessageBox.Show("Введенные данные неверны!",
                            "Пользователь не существует!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    var hashPassword = new Authorizator()
                        .GenerateSHA256Hash(textBoxPassword.Text, user.Salt);

                    if (hashPassword != user.Password)
                    {
                        MessageBox.Show("Введенные данные неверны!",
                        "Пользователь не существует!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                        return;
                    }

                    user.IsOnShift = true;
                    db.SaveChanges();
                    CurrentUser.User = user;

                    if (!CurrentUser.IsAdmin() &&
                        (db.Shifts.ToList().LastOrDefault() == null
                        || db.Shifts.ToList().LastOrDefault().ClosedAt != null))
                    {
                        db.Shifts.Add(new Shift());
                        db.SaveChanges();
                    }

                    var mainForm = new MainForm();
                    this.Hide();
                    CurrentShift.Shift = db.Shifts.ToList().LastOrDefault();
                    mainForm.ShowDialog();
                    CurrentUser.User = null;
                    textBoxLogin.Clear();
                    textBoxPassword.Clear();
                    this.Show();
                }

                return;
            }

            if (textBoxLogin.Text != textBoxPassword.Text)
            {
                var tooltip = new ToolTip();

                tooltip.SetToolTip(textBoxPassword, "");
                tooltip.Show("Пароли должны совпадать!", textBoxPassword, 2000);

                return;
            }

            var regex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$");

            if (!regex.IsMatch(textBoxLogin.Text))
            {
                var tooltip = new ToolTip();

                tooltip.SetToolTip(textBoxLogin, "");
                tooltip.ToolTipTitle = "Пароль должен содержать:";
                tooltip.Show("- строчные и прописные латинские буквы\n" +
                             "- не менее одной цифры\n" +
                             "- не менее одного специального символа\n" +
                             "- от 8 до 15 символов"
                             , textBoxLogin, 2000);

                return;
            }

            using (var db = new RestManDbContext())
            {
                var user = db.Users.FirstOrDefault(x => x.Id == CurrentUser.User.Id);

                var authorizator = new Authorizator();
                var salt = authorizator.CreateSalt(16);
                var hashPassword = authorizator.GenerateSHA256Hash(textBoxPassword.Text, salt);

                user.Password = hashPassword;
                user.Salt = salt;

                db.SaveChanges();
            }

            this.Close();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            buttonEnter.Enabled = !string.IsNullOrEmpty(textBoxLogin.Text) 
                && !string.IsNullOrEmpty(textBoxPassword.Text);
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            if (isAuthForm)
            {
                using (var db = new RestManDbContext())
                {
                    var shift = db.Shifts.ToList().LastOrDefault();

                    if (shift != null && DateTime.Now - shift.OpenedAt > new TimeSpan(20, 0, 0))
                    {
                        shift.ClosedAt = DateTime.Now;

                        var users = db.Users.Where(x => x.IsOnShift == true);

                        foreach (User user in users)
                        {
                            user.IsOnShift = false;
                        }

                        db.SaveChanges();
                    }
                }

                return;
            }

            labelLogin.Text = "Пароль:";
            textBoxLogin.UseSystemPasswordChar = true;
            labelPassword.Text = "Повтор:";
            this.Text = "Изменение пароля";
            buttonEnter.Text = "Ок";
            buttonExit.Text = "Отмена";
        }
    }
}
