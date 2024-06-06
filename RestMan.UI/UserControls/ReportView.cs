using RestMan.Context;
using RestMan.Context.Models;
using RestMan.UI.StaticClasses;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RestMan.UI.UserControls
{
    public partial class ReportView : UserControl
    {
        private int? paidByCash;
        private int? paidByCredit;
        private int? paidByQR;
        private int? paidByGift;
        private int? total;
        public User User { get; set; }
        public ReportView(User user)
        {
            InitializeComponent();
            this.User = user;
            Initialize();
        }

        private void Initialize()
        {
            using (var db = new RestManDbContext())
            {
                labelFullname.Text = User.Fullname;

                var orders = db.Orders.Where(x => x.ShiftId == CurrentShift.Shift.Id
                                                  && (x.WaiterId == User.Id
                                                     || User.Id == -1));

                labelRole.Text = User.Role?.Title;

                paidByCash = orders.Sum(x => x.PaidByCash) ?? 0;
                labelCash.Text = paidByCash.ToString();
                paidByCredit = orders.Sum(x => x.PaidByCredit) ?? 0;
                labelCredit.Text = paidByCredit.ToString();
                paidByQR = orders.Sum(x => x.PaidByQR) ?? 0;
                labelQR.Text = paidByQR.ToString();
                paidByGift = orders.Sum(x => x.PaidByGiftCard) ?? 0;
                labelGift.Text = paidByGift.ToString();
                total = paidByCash + paidByCredit + paidByQR + paidByGift;
                labelTotal.Text = total.ToString();
                labelTotalTitle.Text = $"Итого ({orders.Count()} заказов):";
            }
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            if (User.Id == -1)
            {
                panel.BackColor = Color.Tan;
            }
        }

        private void tableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (User.Id == -1)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds);
            }
        }
    }
}
