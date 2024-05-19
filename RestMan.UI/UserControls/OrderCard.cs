using RestMan.Context;
using RestMan.Context.Models;
using RestMan.UI.Forms;
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
    public partial class OrderCard : UserControl
    {
        public Order Order { get; set; }
        public List<OrderMenuItem> OrderMenuItems { get; set; }
        public OrderCard(Order order, List<OrderMenuItem> orderMenuItems)
        {
            InitializeComponent();
            this.Order = order;
            this.OrderMenuItems = orderMenuItems;
            Initialize(order, orderMenuItems);
        }

        public void Initialize(Order order, List<OrderMenuItem> orderMenuItems)
        {
            labelTableNumber.Text += order.Table.Title;
            labelWaiter.Text = order.Waiter.Fullname;
            labelCreatedAt.Text = order.CreatedAt.ToString();
            labelDeletedAt.Text = order.DeletedAt.ToString();

            labelDeletedAt.Visible = labelDeletedCaption.Visible = order.DeletedAt != null;
            this.BackColor = order.DeletedAt != null
                ? Color.RosyBrown
                : Color.PaleGreen;

            var sum = 0;

            foreach (var menuItem in orderMenuItems)
            {
                var cost = menuItem.MenuItem.Cost;
                var count = menuItem.Count;

                sum += cost * count;
            }

            labelSum.Text += sum + " руб.";
        }

        private void OrderCard_Click(object sender, EventArgs e)
        {
            var editOrderForm = new EditOrderForm(Order);
            this.ParentForm.Hide();
            editOrderForm.Order = this.Order;
            editOrderForm.ShowDialog();
            this.ParentForm.Show();
        }
    }
}
