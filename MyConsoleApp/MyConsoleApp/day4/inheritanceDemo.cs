using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day4
{
    public class inheritanceDemo
    {
        public inheritanceDemo() {
            // initialize global variables
            Console.WriteLine("Parent Default Constructor Called");
        }

        public inheritanceDemo(int x): this() 
        {
            // initialize global variables
            Console.WriteLine("Parent Parameterised  Constructor Called");
        }


        public void hi()
        {
            Console.WriteLine("Hello this is parent class");
        }
    }

    public class ChildClass : inheritanceDemo
    {   
        public ChildClass(): this(100)
        {
            Console.WriteLine("Child Default Constructor called");
        }

        public ChildClass(int x): base(100) // calls the both Parameterised constructor of parent and child class
        {
            Console.WriteLine("Child Parameterised Constructor called");
        } 

        public void hi()
        {
            Console.WriteLine("Hello this is child class");
            base.hi(); // calls base class method (super keyword)
        }
    }
}
