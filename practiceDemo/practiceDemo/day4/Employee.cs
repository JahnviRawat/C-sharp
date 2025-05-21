using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day4
{
    internal class EmployeeClass
    {
        public enum Deptlist
        {
            Sales, HR
        }
        public enum DesignationList
        {
            Manager, Employee
        }

        public string eId;

        public string empId
        {
            
            set {
                eId = value;
                while (!eId.StartsWith("e")) {
                    Console.WriteLine("Wrong Input");
                    Console.WriteLine("Enter Emp Id");
                    Console.ReadLine();
                }
            }
            get { return eId; }
        }

        public string edept;
        public string dept
        {

            set
            {
                edept = value;
                while (edept!="Sales" && edept != "HR")
                {
                    Console.WriteLine("Wrong Input");
                    Console.WriteLine("Enter Emp Dept");
                    Console.ReadLine();
                }
            }
            get { return edept; }
        }

        public int eSalary;
        public int salary
        {

            set
            {
                eSalary = value;
                while (eSalary < 0)
                {
                    Console.WriteLine("Wrong Input");
                    Console.WriteLine("Enter Emp salary");
                    Console.ReadLine();
                }
            }
            get { return eSalary; }
        }

        public string eDesignation;
        public string designation
        {

            set
            {
                eDesignation = value;
                while (eDesignation != "Manager" && eDesignation != "Employee")
                {
                    Console.WriteLine("Wrong Input");
                    Console.WriteLine("Enter Emp salary");
                    Console.ReadLine();
                }
            }
            get { return eDesignation; }
        }

        public void printEmpDetails()
        {
            Console.WriteLine($" EmpId: {empId}, Department: {dept}, Salary: {salary}, Designation: {designation} ");
        }
    }


}
