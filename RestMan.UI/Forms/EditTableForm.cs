using RestMan.Context;
using RestMan.Context.Models;
using System;
using System.Data;
using System.Linq;
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
                var tables = db.Tables.Where(x => db.Orders.Where(y => y.TableId == x.Id
                                                                && y.ShiftId == CurrentShift.Shift.Id
                                                                && !y.DeletedAt.HasValue).Count() == 0);
                var hallsId = tables.Select(x => x.HallId).Distinct().ToList();

                var halls = db.Halls.Where(x => hallsId.Contains(x.Id));

                if (halls.Count() == 0)
                {
                    MessageBox.Show("Свободных столов нет!", "Полная посадка!", MessageBoxButtons.OK);
                    this.Close();
                    return;
                }

                comboBoxHall.Items.Clear();
                comboBoxHall.Items.AddRange(halls.ToArray());
                comboBoxHall.DisplayMember = nameof(Hall.Title);

                if (Table == null)
                {
                    comboBoxHall.SelectedIndex = 0;
                    return;
                }

                comboBoxHall.SelectedItem = comboBoxHall
                                            .Items
                                            .Cast<Hall>()
                                            .FirstOrDefault(x => x.Id == Table.HallId);
            }
        }

        private void GetTablesByHall()
        {
            using (var db = new RestManDbContext())
            {
                var hall = ((Hall)comboBoxHall.SelectedItem);

                comboBoxTable.Items.Clear();
                comboBoxTable.Items.AddRange(db.Tables.Where(x => x.HallId == hall.Id
                                                            && db.Orders.Where(y => y.TableId == x.Id
                                                                                && y.ShiftId == CurrentShift.Shift.Id
                                                                                && !y.DeletedAt.HasValue).Count() == 0)
                                                                        .ToArray());
                comboBoxTable.DisplayMember = nameof(Table.Title);

                if (Table == null)
                {
                    comboBoxTable.SelectedIndex = 0;
                    return;
                }

                comboBoxTable.SelectedItem = comboBoxTable
                            .Items
                            .Cast<Table>()
                            .FirstOrDefault(x => x.Id == this.Table.Id);
            }
        }

        private void comboBoxHall_SelectedIndexChanged(object sender, EventArgs e)
        {
            Table = null;
            GetTablesByHall();
        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            Table = (Table)comboBoxTable.SelectedItem;
        }
    }
}
