using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestMan.Context.Models
{
    public class Shop
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}