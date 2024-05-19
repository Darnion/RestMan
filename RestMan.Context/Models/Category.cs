using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestMan.Context.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        public ICollection<MenuItem> MenuItems { get; set;}
    }
}