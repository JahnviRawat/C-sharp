using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day5
{

    interface Iperson
    {
        void getDtails();
    }

    public partial class Employee : Iperson
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string department, int salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }

        public void getDtails()
        {
            Console.WriteLine(Name + Department + Salary);
        }
    }

    public class ManagerDetails : Employee {

        public ManagerDetails(string name, string department, int salary) : base(name, department, salary) { }
        public void getManagerDetails()
        {
            Console.WriteLine("Manager Details");
        }
    }

    public static class extClass
    {
        public static int countOccurence(this string name, char ch)
        {
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ch)
                {
                    count++;
                }
            }
            return count;
        }

        public static int checkEvenCount(this int[] x) 
        {
            int count = 0;
            for (int i = 0; i < x.Length; i++) {
                if (x[i]%2 == 0) {
                    count++;
                }
            }
            return count;
        }
    }
}
