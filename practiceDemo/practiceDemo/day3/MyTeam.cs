using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day3
{
    internal class MyTeam
    {
        public int id { get; set; }
        public string[] teamName { get; set; }

        public void printTeamDetails()
        {
            Console.WriteLine($"id : {id}");
            foreach (var item in teamName)
            {
                Console.WriteLine(item);
            }
        }
    }
}
