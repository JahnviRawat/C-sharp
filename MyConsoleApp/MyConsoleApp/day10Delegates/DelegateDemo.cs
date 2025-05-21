using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day10Delegates
{
    internal class DelegateDemo
    {
        public delegate void myDel(int x); // delegate creation

        //public void even(int x)
        //{
           
        //    Console.WriteLine(x + " Even called");
        //}

        public void odd(int x)
        {
            Console.WriteLine(x + " Odd called");
        }

        public void show(int i)
        {
            myDel ob;
            if (i % 2 == 0) {
                //Method 1
                //ob = new myDel(even);  // delegate instantiation

                //method 2
                //ob = even;

                // Method 3   // Amonymous delegate
                //ob = delegate (int x)
                //{
                //    Console.WriteLine(x + " Even Called");
                //};
                
                // Method 4 //lambda Expression // you don't have to define the datatype
                
                ob = (x) => { Console.WriteLine(x + " Even Called"); };
            }
            else
            {
                //ob = new myDel(odd);
                ob = odd;
            }

            ob.Invoke(i);  // delegate invocation
        }
    }
}
