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
    public partial class PaymentRow : UserControl
    {
        public string Title { get; set; }
        public int Count { get; set; }
        public PaymentRow()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {

        }
    }
}
