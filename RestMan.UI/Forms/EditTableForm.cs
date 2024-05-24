﻿using RestMan.Context;
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
    public partial class EditTableForm : Form
    {
        public Table Table { get; set; }
        public EditTableForm()
        {
            InitializeComponent();
        }

        private void EditTableForm_Load(object sender, EventArgs e)
        {
            using (var db = new RestManDbContext())
            {
                comboBoxHall.Items.Clear();
                comboBoxHall.Items.AddRange(db.Halls.ToArray());
                comboBoxHall.DisplayMember = nameof(Hall.Title);
                comboBoxHall.SelectedItem = comboBoxHall
                                            .Items
                                            .Cast<Hall>()
                                            .FirstOrDefault(x => x.Id == this.Table.HallId);


            }
        }

        private void GetTablesByHall()
        {
            using (var db = new RestManDbContext())
            {
                var hall = ((Hall)comboBoxHall.SelectedItem);

                comboBoxTable.Items.Clear();
                comboBoxTable.Items.AddRange(db.Tables.Where(x => x.HallId == hall.Id).ToArray());
                comboBoxTable.DisplayMember = nameof(Table.Title);
                comboBoxTable.SelectedItem = comboBoxTable
                                            .Items
                                            .Cast<Table>()
                                            .FirstOrDefault(x => x.Id == this.Table.Id);
            }
        }

        private void comboBoxHall_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTablesByHall();
        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            Table = (Table)comboBoxTable.SelectedItem;
        }
    }
}
