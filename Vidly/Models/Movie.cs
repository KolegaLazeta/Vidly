using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Required]

        public DateTime DateAdded { get; set; }
        [Required]
        [Display(Name = "Number In Stock")]

        public string NumberInStock { get; set; }
        public Genre Genre { get; set; }
        [Required]

        public byte GenreId { get; set; }

    }
}