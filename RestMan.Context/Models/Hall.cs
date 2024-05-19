using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMan.Context.Models
{
    public class Hall
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public ICollection<Table> Tables { get; set; }
    }
}
