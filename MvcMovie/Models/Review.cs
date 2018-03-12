using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ForeignKey("Movie")]
        public int MovieID { get; set; }
        public Movie Movie { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(400, MinimumLength = 5)]
        public string Comment { get; set; }
    }
}
