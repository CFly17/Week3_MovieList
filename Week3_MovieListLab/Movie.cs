using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_MovieListLab
{
    class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }

        public Movie(string Title, int Year, string Genre)
        {
            this.Title = Title;
            this.Year = Year;
            this.Genre = Genre;
        }

    }
}
