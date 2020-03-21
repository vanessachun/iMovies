using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iMovies.Models
{
    public class DisplayMovieModel
    {
        [Required]
        [StringLength(65, ErrorMessage = "Movie is too long.")]
        [MinLength(1, ErrorMessage = "Movie is too short.")]
        public string Movie { get; set; }
        [Required]
        [StringLength(5, ErrorMessage = "Year is too long.")]
        [MinLength(2, ErrorMessage = "Year is too short.")]
        public int Year { get; set; }

        [Required]
        public string Summary { get; set; }
    }
}
