using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movie.Entities
{
    public class MovieProp
    {
        [Key]
        public int movieID { get; set; }

        [StringLength(100)]
        public string title { get; set; }
        public string runtime { get; set; }

    }
}
