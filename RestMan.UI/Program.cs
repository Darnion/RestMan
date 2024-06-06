using RestMan.Context;
using RestMan.UI.Common;
using RestMan.UI.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RestMan.UI
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var db = new RestManDbContext())
            {
                var authorizator = new Authorizator();

                var users = db.Users.Where(x => x.Salt == string.Empty).ToList();
                foreach (var user in users)
                {
                    var salt = authorizator.CreateSalt(16);
                    var hashPassword = authorizator.GenerateSHA256Hash(user.Password, salt);

                    user.Password = hashPassword;
                    user.Salt = salt;
                }

                db.SaveChanges();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }
    }
}
