using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    internal class firstClass
    {
        public static void Add()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine()); 
            int c = a + b;
            //Console.WriteLine("The sum of " + a +" and  "+  b + " is " + c);
            //Console.WriteLine("The sum of {0} and {1} is {2}",a,b,c);
            Console.WriteLine($"the sum of {a} and {b} is {c}");

            //string i  = Console.ReadLine();
            //Console.WriteLine(i);

        }

        public static void Greatest() {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"{a} is greatest");
            }
            else
            {
                Console.WriteLine($"{b} is greatest");
            }
        }
    }
}
