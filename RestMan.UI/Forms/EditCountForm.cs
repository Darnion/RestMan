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
    public partial class EditCountForm : Form
    {
        public int Count { get; set; } = 1;
        public EditCountForm()
        {
            InitializeComponent();
        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(numericUpDownCount.Value.ToString(), out var count))
            {
                this.Count = count;
            };
        }

        private void EditCountForm_Load(object sender, EventArgs e)
        {
            numericUpDownCount.Value = this.Count;
        }
    }
}
