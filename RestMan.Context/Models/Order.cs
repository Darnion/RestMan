using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMan.Context.Models
{
    public class Order
    {
        public long Id { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public long WaiterId { get; set; }
        public User Waiter { get; set; }
        public long TableId { get; set; }
        public Table Table { get; set; }
        public long ShiftId { get; set; }
        public Shift Shift { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? PaidByGiftCard { get; set; } = 0;
        public int? PaidByCash { get; set; } = 0;
        public int? PaidByCredit { get; set; } = 0;
        public int? PaidByQR { get; set; } = 0;
        public int? ChangeGiven { get; set; } = 0;
    }
}
