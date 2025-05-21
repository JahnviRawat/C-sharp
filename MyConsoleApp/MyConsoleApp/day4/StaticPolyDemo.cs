using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day4
{
    internal class StaticPolyDemo
    {
        public void add(int x, int y )
        {
            Console.WriteLine($"The sum of integer is : {x+y}");
            
        }

        public void add(float x, float y)
        {
            Console.WriteLine($"The sum of Float is : {x + y}");
            
        }

        public void add(double x, double y)
        {
            Console.WriteLine($"The sum of Double is : {x + y}");
            
        }
    }
}
