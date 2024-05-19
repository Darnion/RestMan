using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMan.Context.Models
{
    public class Role
    {
        public int Id { get; set; }
        [MaxLength(255)]
        [Required]
        public string Title { get; set; }
        public ICollection<User> Users { get; set;}
    }
}
