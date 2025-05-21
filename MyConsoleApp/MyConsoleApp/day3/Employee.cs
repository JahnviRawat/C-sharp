using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day3
{
    internal class Employee
    {

        int a;
        public int age
        {
            set
            {
                a = value;
                while (a < 0 || a > 120)
                {
                    Console.WriteLine("Enter Age");
                    a = int.Parse(Console.ReadLine());
                }
            }
            get
            {
                return a;
            }
        }

        string n;
        public String name
        {

            set {
                n = value;

               while (!n.StartsWith("M") && n.Length < 5){
                    Console.WriteLine("Invalid name");
                }
            }
            get
            {
                return n.ToUpper();
            }
        }


        private string add;

        public string address
        {
            
            set {
                add = value;
                while ( add!="bangalore" && add!="chennai" && add != "Hyderabad")
                {
                    Console.WriteLine("Invaid Address");
                    Console.WriteLine("Enter Address Again");
                    add = Console.ReadLine();
                }
            }
            get { return add; }
        }

        //automatic property, without validations
        public string id { get; set; }


    }
}
