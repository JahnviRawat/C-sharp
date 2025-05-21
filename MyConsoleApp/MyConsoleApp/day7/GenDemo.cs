using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day7
{
    interface Igen<T>
    {
        void Swap(T num1, T num2);
    }

    class TestGen<T> where T : struct //:class
    {
        
    }
    internal class GenDemo<T> : Igen<T>
    {
        public void Swap(T num1, T num2)
        {
            Console.WriteLine($"first : {num1} , second: {num2}");
            T temp;
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"first : {num1} , second: {num2}");
        }
        public void hello(T str)
        {
            Console.WriteLine("Hello");
        }
    }
}
