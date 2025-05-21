using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day4
{
    internal interface IMath
    {
        void Add(int x, int y);
        void Sub(int x, int y);
    }

    internal interface IMath2
    {
        void multiply(int x, int y);
        void divide(int x, int y);
        void Add(int x, int y);
    } 

    class MathClass : IMath,IMath2
    {
        //explicit interface declaration
        void IMath.Add(int x, int y)
        {
            Console.WriteLine($"Sum: {x+y}");
        }

        void IMath2.Add(int x, int y)
        {
            Console.WriteLine($"Addition: {x + y}");
        } 

        public void divide(int x, int y)
        {
            Console.WriteLine($"division: {x / y}");
        }

        public void multiply(int x, int y)
        {
            Console.WriteLine($"multiplication: {x * y}");
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction: {x - y}");
        }
    }

}
