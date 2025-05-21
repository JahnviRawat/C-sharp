using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day3
{
    internal class movies
    {
        public int movieId { get; set; }
        public String movieName { get; set; }
        public String actor { get; set; }
        public String actress { get; set; }

        public void printMovie()
        {
            Console.WriteLine($"Movie Id: {movieId}, Movie Name: {movieName}, Actor: {actor}, actress: {actress}");
        }

    }
}
