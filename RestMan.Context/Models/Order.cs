using System;
using System.ComponentModel.DataAnnotations;

namespace RestMan.Context.Models
{
    public class Order : ICloneable
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

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
