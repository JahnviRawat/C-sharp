using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day3
{
    internal class Ipl
    {
        public string tName { get; set; }
        public string captain { get; set; }
        public int budget { get; set; }

        // behaviour

        public void printTeam()
        {
            Console.WriteLine($"Teamname: {tName}, Team Captain: {captain}, Team Budget: {budget}");
        }
    }
}
