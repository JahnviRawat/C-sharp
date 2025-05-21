using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day3
{
    
    // this demonstrates encapsulation, binding the properties and methods into single unit, a.k.a class
    internal class Login
    {
        public string UserName;
        public string Password;

        /// <summary>
        /// Validate data from database
        /// </summary>
        public void Validate()
        {
            if(UserName == "Morvi" || Password == "123")
            {
                Console.WriteLine( "Valid User");
            }
            else
            {
                Console.WriteLine("Invalid user");
            }
        }
    }
}
