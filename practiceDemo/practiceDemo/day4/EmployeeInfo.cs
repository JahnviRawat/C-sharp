using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day4
{
    internal class EmployeeInfo
    {
        public string Name { get; set; }
        public int yearOfJoining { get; set; }
        public int salary { get; set; }
        public string address { get; set; }

        public void displayDetails()
        {
            Console.WriteLine($"{Name} {yearOfJoining} {salary} {address}");
        }
    }
}
