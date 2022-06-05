using System;

namespace MovieDLL
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int LengthInMinutes { get; set; }
        public int ConvertLengthInMinutesToSeconds()
        {
            if (LengthInMinutes == 0 || LengthInMinutes < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return LengthInMinutes * 60;
        }
    }
}
