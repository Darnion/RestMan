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
    public partial class OrderCardView : UserControl
    {
        public Order Order { get; set; }
        public List<OrderMenuItem> OrderMenuItems { get; set; }
        public bool IsOrderCard = true;
        public OrderCardView(Order order, List<OrderMenuItem> orderMenuItems, bool isOrderCard)
        {
            InitializeComponent();
            this.Order = order;
            this.OrderMenuItems = orderMenuItems;
            this.IsOrderCard = isOrderCard;
            Initialize(order, orderMenuItems);
        }

        private void Initialize(Order order, List<OrderMenuItem> orderMenuItems)
        {
            labelTableNumber.Text += order.Table.Title;
            labelWaiter.Text = order.Waiter.Fullname;
            labelCreatedAt.Text = order.CreatedAt.ToString();
            labelDeletedAt.Text = order.DeletedAt.ToString();

            labelDeletedAt.Visible = labelDeletedCaption.Visible = order.DeletedAt != null;

            if (IsOrderCard)
            {
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

                return;
            }

            this.BackColor = Color.White;
            labelSum.Text = string.Empty;
        }

        private void OrderCard_Click(object sender, EventArgs e)
        {
            if (IsOrderCard)
            {
                var editOrderForm = new EditOrderForm(Order)
                {
                    Order = this.Order,
                    OrderMenuItems = this.OrderMenuItems,
                };
                this.ParentForm.Hide();
                editOrderForm.ShowDialog();
                this.ParentForm.Show();
            }
        }
    }
}
