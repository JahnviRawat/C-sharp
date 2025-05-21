using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day3
{
    internal class car
    {
        public int id { get; set; }

        public void displaycardetails()
        {
            Console.WriteLine($"id: {id}");
        }
    }
}
