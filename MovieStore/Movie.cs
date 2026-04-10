using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore
{
    internal class Movie
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime YearOfRelease { get; set; }
        public string Genre { get; set; }

        public Movie(string name, int id, DateTime year, string genre)
        {
            Name = name;
            Id = id;
            YearOfRelease = year;
            Genre = genre;
        }
    }
}
