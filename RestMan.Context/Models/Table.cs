using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMan.Context.Models
{
    public class Table
    {
        public long Id { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        public long HallId { get; set; } 
        public Hall Hall { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
