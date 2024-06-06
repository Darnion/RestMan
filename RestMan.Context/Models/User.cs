using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public bool IsOnShift { get; set; } = false;
        public int? DisplayColor { get; set; }
    }
}
