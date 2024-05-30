using System.ComponentModel.DataAnnotations;

namespace RestMan.Context.Models
{
    public class MenuItem
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        public int Cost { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public bool IsStopListed { get; set; } = false;
    }
}
