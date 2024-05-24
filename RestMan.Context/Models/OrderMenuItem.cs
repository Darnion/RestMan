using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMan.Context.Models
{
    public class OrderMenuItem
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public Order Order { get; set; }
        public long MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }
        [Required]
        public int Count { get; set; } = 1;
    }
}
