using System;
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

        public string edited { get; set; }

        public string lentTo { get; set; }

        public string notes { get; set; }
    }
}
