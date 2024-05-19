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
        public int Id { get; set; }
        [MaxLength(255)]
        [Required]
        public string Title { get; set; }
        public int HallId { get; set; } 
        public Hall Hall { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
