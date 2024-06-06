using RestMan.Context.Models;
using RestMan.UI.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RestMan.UI.UserControls
{
    public partial class OrderCardView : UserControl
    {
        public Order Order { get; set; }
        public int Total { get; set; }
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

            int hallColor = order.Table.Hall.DisplayColor ?? Color.Transparent.ToArgb();

            buttonHallColor.BackColor =
                buttonHallColor.FlatAppearance.MouseOverBackColor =
                buttonHallColor.FlatAppearance.MouseDownBackColor = Color.FromArgb(hallColor);

            int waiterColor = order.Waiter.DisplayColor ?? Color.Transparent.ToArgb();

            buttonWaiterColor.BackColor =
                buttonWaiterColor.FlatAppearance.MouseOverBackColor =
                buttonWaiterColor.FlatAppearance.MouseDownBackColor = Color.FromArgb(waiterColor);

            labelDeletedAt.Visible = labelDeletedCaption.Visible = order.DeletedAt != null;

            buttonHallColor.Visible = IsOrderCard && order.Table.Hall.DisplayColor != null;
            buttonWaiterColor.Visible = IsOrderCard && order.Waiter.DisplayColor != null;

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

                Total = sum;
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
                var editOrderForm = new EditOrderForm(this.Order);
                this.ParentForm.Hide();
                editOrderForm.ShowDialog();
                this.ParentForm.Show();
            }
        }
    }
}
