using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestMan.Context.Models
{
    public class Shift
    {
        public long Id { get; set; }
        [Required]
        public DateTime OpenedAt { get; set; } = DateTime.Now;
        public DateTime? ClosedAt { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
