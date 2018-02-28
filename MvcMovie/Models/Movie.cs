using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 1), Required]
        public string Title { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Required, StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Genre may not contain numbers.")]
        public string Genre { get; set; }

        [Range(1, 100), DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [StringLength(5), Required]
        public string Rating { get; set; }
    }
}
