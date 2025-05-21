using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    internal class ParamDemo
    {
        public static void refTypeDemo(ref int num)
        {
            num += 10;
            Console.WriteLine(num);
        }

        public static void outDemo(int a , int b, out int sum, out int prod)
        {
            sum = a + b;
            prod = a * b;

        }

        public static void optionalDemo(int a=10, int b=20)
        {
            Console.WriteLine(a+b);

        }

        // a method can have only one params keyword
        // parameter array should always be the last parameter of a function
        public static void paramArrayDemo(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr){
                sum += i;
            }
            Console.WriteLine($"Sum is : {sum}");
        }


    }


}
