using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace practiceDemo.day4
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Employee: Person
    {
        public int salary { get; set; }
    }

    internal class Manager : Employee
    {
        public int Bonus { get; set; }

        public void displayDetails()
        {
            Console.WriteLine($" Name: {Name} , Age: {Age} , Salary: {salary}, Bonus: {Bonus}");
        }
    }
}
