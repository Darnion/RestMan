﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace RestMan.Context.Models
{
    public class Hall
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(8)]
        public string Acronym { get; set; }

        public int? DisplayColor { get; set; }

        public ICollection<Table> Tables { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
