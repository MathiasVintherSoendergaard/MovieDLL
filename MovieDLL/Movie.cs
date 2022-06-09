using System;

namespace MovieDLL
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int LengthInMinutes { get; set; }

        public TimeCalculator tc = new TimeCalculator();

        
    }
}
