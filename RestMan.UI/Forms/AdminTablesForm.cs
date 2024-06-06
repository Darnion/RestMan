﻿using RestMan.Context;
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
                dataGridViewTables.DataSource = db.Tables.Include(x => x.Hall).OrderBy(x => x.Title).ToList();
            }
        }

        private void comboBoxHall_SelectedIndexChanged(object sender, EventArgs e)
        {

            FillAcronym();
            Filter();

            textBoxAcronym.Enabled = !string.IsNullOrWhiteSpace(comboBoxHall.Text)
                                     && ((Hall)comboBoxHall.SelectedItem)?.Id != -1;

            buttonAddTable.Enabled =
            buttonDeleteHall.Enabled = comboBoxHall.SelectedIndex != -1
                                       && ((Hall)comboBoxHall.SelectedItem)?.Id != -1;
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

            if (hall != null)
            {
                textBoxAcronym.Text = hall.Id != -1
                                        ? hall.Acronym
                                        : null;
            }

        }

        private void Filter()
        {
            using (var db = new RestManDbContext())
            {
                var hall = (Hall)comboBoxHall.SelectedItem;

                if (hall != null)
                {
                    dataGridViewTables.DataSource = db.Tables.Include(x => x.Hall)
                                                         .Where(x => x.HallId == hall.Id
                                                                     || hall.Id == -1)
                                                         .ToList();
                }
            }

            dataGridViewTables.ClearSelection();

            buttonDeleteTable.Enabled = comboBoxHall.SelectedIndex != -1
                                       && ((Hall)comboBoxHall.SelectedItem)?.Id != -1
                                       && dataGridViewTables.RowCount > 0;
        }

        private void textBoxAcronym_TextChanged(object sender, EventArgs e)
        {
            var acronym = ((Hall)comboBoxHall.SelectedItem)?.Acronym ?? string.Empty;

            buttonSave.Visible = !string.IsNullOrWhiteSpace(textBoxAcronym.Text)
                                 && textBoxAcronym.Text != acronym;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                var isAcronymExist = db.Halls.Where(x => x.Acronym == textBoxAcronym.Text).Any();

                if (isAcronymExist)
                {
                    MessageBox.Show("Такое сокращение уже существует",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                var selectedHall = (Hall)comboBoxHall.SelectedItem;

                if (selectedHall == null)
                {
                    var hall = new Hall()
                    {
                        Id = -1,
                        Title = comboBoxHall.Text,
                        Acronym = "??",
                    };

                    db.Halls.Add(hall);
                    db.SaveChanges();
                }

                var id = selectedHall?.Id ?? -1;

                var hallDB = db.Halls.FirstOrDefault(x => x.Id == id);

                if (hallDB == null)
                {
                    hallDB = db.Halls.OrderByDescending(x => x.Id).FirstOrDefault();
                }

                hallDB.Title = comboBoxHall.Text.Trim();
                hallDB.Acronym = textBoxAcronym.Text.Trim();

                var tables = db.Tables.Where(x => x.HallId == hallDB.Id);
                var number = 0;

                foreach (var table in tables)
                {
                    number++;
                    table.Title = hallDB.Acronym + number;
                }

                db.SaveChanges();

                FillHalls();
                comboBoxHall.SelectedItem = comboBoxHall.Items.Cast<Hall>().FirstOrDefault(x => x.Id == hallDB.Id);
            }
        }

        private void comboBoxHall_Leave(object sender, EventArgs e)
        {
            var hall = comboBoxHall.Items.Cast<Hall>()
                                         .FirstOrDefault(x => x.Title.ToLower() == comboBoxHall.Text.ToLower());

            if (hall != null)
            {
                comboBoxHall.SelectedItem = hall;
            }
        }

        private void buttonAddTable_Click(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                var hall = db.Halls.Include(x => x.Tables).FirstOrDefault(x => x.Id == ((Hall)comboBoxHall.SelectedItem).Id);

                var table = new Table()
                {
                    HallId = hall.Id,
                    Title = hall.Acronym + (hall.Tables.Count + 1),
                };

                db.Tables.Add(table);
                db.SaveChanges();

                Filter();
            }

            var rowIndex = dataGridViewTables.RowCount - 1;
            if (rowIndex > 0)
            {
                dataGridViewTables.FirstDisplayedScrollingRowIndex = rowIndex;
            }
        }

        private void buttonDeleteTable_Click(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                var hall = db.Halls.FirstOrDefault(x => x.Id == ((Hall)comboBoxHall.SelectedItem).Id);

                var table = db.Tables.Where(x => x.HallId == hall.Id).OrderByDescending(x => x.Id).FirstOrDefault();

                db.Tables.Remove(table);
                db.SaveChanges();

                Filter();
            }

            var rowIndex = dataGridViewTables.RowCount - 1;
            if (rowIndex > 0)
            {
                dataGridViewTables.FirstDisplayedScrollingRowIndex = rowIndex;
            }

        }

        private void buttonDeleteHall_Click(object sender, EventArgs e)
        {
            var hall = (Hall)comboBoxHall.SelectedItem;

            if (MessageBox.Show($"Вы уверены, что хотите удалить зал \"{hall.Title}\" и столы: {dataGridViewTables.RowCount}?",
                "Подтвердите действие",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            using (var db = new RestManDbContext())
            {
                var hallDB = db.Halls.FirstOrDefault(x => x.Id == hall.Id);

                db.Halls.Remove(hallDB);
                db.SaveChanges();

                FillHalls();
            }
        }

        private void comboBoxHall_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxHall.SelectedIndex = -1;
        }
    }
}
