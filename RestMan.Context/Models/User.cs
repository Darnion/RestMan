using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMan.Context.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(255)]
        [Index(IsUnique = true)]
        public string Login { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }

        [Required]
        [MaxLength(255)]
        public string Salt { get; set; }
        public long RoleId { get; set; }
        public Role Role { get; set; }
    }
}
