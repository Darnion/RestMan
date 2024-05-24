using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestMan.Context.Models
{
    public class Category
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        public long ShopId { get; set; }
        public Shop Shop { get; set; }
        public ICollection<MenuItem> MenuItems { get; set;}
    }
}