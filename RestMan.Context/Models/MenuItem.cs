using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMan.Context.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Cost { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool IsStopListed { get; set; } = false;
    }
}
