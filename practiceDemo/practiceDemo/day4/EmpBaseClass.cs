using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day4
{
    internal abstract class EmpBaseClass
    {
        public int empId { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string dept { get; set; }

        public abstract void calcSalary();

        public void displayDetails()
        {
            Console.WriteLine($"Empid: {empId}, First Name: {fName}, Last Name: {lName}, Department: {dept} ");
        }

    }

    internal class PartTimeEmp: EmpBaseClass
    {
        public int totalHoursWorked { get; set; }
        public double RatePerHour { get; set; }

        public override void calcSalary()
        {
            Console.WriteLine($"Salary: {totalHoursWorked * RatePerHour} ");
        }
    }

    internal class FullTimeEmp : EmpBaseClass 
    {
        public int MonthlySalary { get; set; }

        public override void calcSalary()
        {
            Console.WriteLine($"Salary: {MonthlySalary} ");
        }
    }
}
