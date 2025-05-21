using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day4
{
    internal class PersonCls
    {
        public string firstName { get; set; }
        public string lastname { get; set; }
        public DateTime dob { get; set; }

        public PersonCls(string firstName, string lastName, string dob)
        {
            this.firstName = firstName;
            this.lastname = lastName;
            this.dob = DateTime.Parse(dob);

        }

        public void printDetails()
        {
            if (this.dob == DateTime.Now)
            {
                Console.WriteLine("Happy Birthday");
            }
            else {
                Console.WriteLine("Today is not your birthday");
            }

            if((DateTime.Now.Year - this.dob.Year) > 18)
            {
                Console.WriteLine("Greater than 18");
            }
            else {
                Console.WriteLine("Under Aged");
            }

            
        }
        
    }
}
