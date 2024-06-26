﻿using System;
using System.Windows.Forms;

namespace RestMan.UI.Forms
{
    public partial class EditCountForm : Form
    {
        public int Count { get; set; } = 1;
        public int MaxValue { get; set; } = 100;
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
            numericUpDownCount.Maximum = this.MaxValue;
            numericUpDownCount.Value = this.Count;
        }
    }
}
