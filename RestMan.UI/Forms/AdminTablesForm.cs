using RestMan.Context;
using RestMan.Context.Models;
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
    public partial class AdminTablesForm : Form
    {
        public AdminTablesForm()
        {
            InitializeComponent();
            dataGridViewTables.AutoGenerateColumns = false;
            InitTables();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminTablesForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelFullname.Text = CurrentUser.User.Fullname;
            toolStripStatusLabelRole.Text = CurrentUser.User.Role.Title;
            dataGridViewTables.ClearSelection();

            FillHalls();
        }

        private void InitTables()
        {
            using (var db = new RestManDbContext())
            {
                dataGridViewTables.DataSource = db.Tables.Include(x => x.Hall).ToList();
            }
        }

        private void comboBoxHall_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAcronym.Enabled = !string.IsNullOrWhiteSpace(comboBoxHall.Text)
                                     && ((Hall)comboBoxHall.SelectedItem).Id != -1;

            FillAcronym();

            Filter();
        }

        private void FillHalls()
        {
            using (var db = new RestManDbContext())
            {
                comboBoxHall.Items.Clear();
                comboBoxHall.Items.AddRange(db.Halls.ToArray());
                comboBoxHall.DisplayMember = nameof(Hall.Title);
                comboBoxHall.Items.Insert(0, new Hall()
                {
                    Id = -1,
                    Title = "Все залы",
                });
                comboBoxHall.SelectedIndex = 0;
            }
        }

        private void FillAcronym()
        {
            textBoxAcronym.Text = null;

            var hall = (Hall)comboBoxHall.SelectedItem;

            textBoxAcronym.Text = hall.Id != -1
                                    ? hall.Acronym
                                    : null;
        }

        private void Filter()
        {
            using (var db = new RestManDbContext())
            {
                var hall = (Hall)comboBoxHall.SelectedItem;

                dataGridViewTables.DataSource = db.Tables.Include(x => x.Hall)
                                                         .Where(x => x.HallId == hall.Id
                                                                     || hall.Id == -1)
                                                         .ToList();
            }
        }

        private void textBoxAcronym_TextChanged(object sender, EventArgs e)
        {
            buttonSave.Visible = !string.IsNullOrWhiteSpace(textBoxAcronym.Text)
                                 && textBoxAcronym.Text != ((Hall)comboBoxHall.SelectedItem).Acronym;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                if (comboBoxHall.SelectedItem == null)
                {
                    var hall = new Hall()
                    {
                        Title = comboBoxHall.Text,
                    };

                    db.Halls.Add(hall);
                }

                //var hallDB = db.Halls.FirstOrDefault(x => x.);
            }
        }

        private void comboBoxHall_Leave(object sender, EventArgs e)
        {
            var hall = comboBoxHall.Items.Cast<Hall>()
                                         .FirstOrDefault(x => x.Title.ToLower() == comboBoxHall.Text.ToLower());

            if (hall != null)
            {

            }
        }
    }
}
