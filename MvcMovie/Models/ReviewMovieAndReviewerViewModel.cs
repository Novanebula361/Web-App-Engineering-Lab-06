using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class ReviewMovieAndReviewerViewModel
    {
        public List<Movie> movies;
        public List<Review> reviews;
        public SelectList reviewerNames;
        public SelectList movieNames;
        public string reviewerName { get; set; }
        public string movieName { get; set; }
    }
}
