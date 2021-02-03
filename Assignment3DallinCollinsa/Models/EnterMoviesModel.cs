using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment3DallinCollinsa.Models
{
    public class EnterMoviesModel
    {
        [Required]
        public string category { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public int year { get; set; }

        [Required]
        public string director { get; set; }

        [Required]
        public string rating { get; set; }

        internal void Add(List<EnterMoviesModel> movies)
        {
            throw new NotImplementedException();
        }

        public bool? edited { get; set; }

        public string lentTo { get; set; }

        [MaxLength(25)]
        public string notes { get; set; }
    }
}
