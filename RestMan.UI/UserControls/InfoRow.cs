using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestMan.UI.UserControls
{
    public partial class InfoRow : UserControl
    {
        public string Title { get; set; }
        public string Value { get; set; }

        public InfoRow(string title, string value)
        {
            InitializeComponent();
            this.Title = title;
            this.Value = value;
            Initialize(title, value);
        }

        private void Initialize(string title, string value)
        {
            labelTitle.Text = title;
            labelValue.Text = value;
        }
    }
}
