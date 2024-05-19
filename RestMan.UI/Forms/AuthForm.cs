using RestMan.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestMan.UI.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                var user = db.Users.Include(x => x.Role)
                                   .SingleOrDefault(x => x.Login == textBoxLogin.Text
                                                    && x.Password == textBoxPassword.Text);

                if (user != null)
                {
                    CurrentUser.User = user;

                    if (!CurrentUser.IsAdmin() &&
                        (db.Shifts.ToList().LastOrDefault() == null 
                       || db.Shifts.ToList().LastOrDefault().ClosedAt != null))
                    {
                        db.Shifts.Add(new Context.Models.Shift());
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
                else
                {
                    MessageBox.Show("Введенные данные неверны!",
                        "Пользователь не существует!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            buttonEnter.Enabled = !string.IsNullOrEmpty(textBoxLogin.Text) 
                && !string.IsNullOrEmpty(textBoxPassword.Text);
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                var shift = db.Shifts.ToList().LastOrDefault();

                if (shift != null && DateTime.Now - shift.OpenedAt > new TimeSpan(20, 0, 0))
                {
                    shift.ClosedAt = DateTime.Now;
                    db.SaveChanges();
                }
            }
        }
    }
}
