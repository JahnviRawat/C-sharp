using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day1
{
    internal class demo1
    {
        public static void greatestOfThree()
        {
            Console.WriteLine("Enter the First number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third number");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine($"the greatest number is : {a}");
            }
            else if (b > a && b > c) {
                Console.WriteLine($"the greatest number is : {b}");
            }
            else
            {
                Console.WriteLine($"the greatest number is : {c}");
            }
        }

        public static void empDetails()
        {
            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            double salary = double.Parse(Console.ReadLine());

            double hra = salary * 0.15;
            double da = salary * 0.1;
            double grossPay = salary + hra + da;
            double tax = grossPay * 0.08;

            Console.WriteLine($"Employee Name : {name} , Employee Salary : {salary} , HRA: {hra}, DA: {da}, GrossPay: {grossPay}, Tax: {tax}");
        }

        public static void factorial()
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int fact = 0;
            if (num != 0)
            {
                for (int i = num; i > 0; i--)
                {
                    fact += num * num - 1;
                }
                Console.WriteLine($"fact : {fact}");
            }
            else
            {
                num = 5;
                for (int i = num; i > 0; i--)
                {
                    fact += num * num - 1;
                }
                Console.WriteLine($"fact : {fact}");

            }
        }

        public static void sumOf10Nums()
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter {i+1} number");
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("Inappropriate value");
                    break;
                }
                else
                {
                    sum += num;
                }  
            }
            Console.WriteLine($"the sum of numbers is: {sum}");
            
        }

        public static void SwapNums()
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before swap a: {a}, b: {b}");

            //int temp = 0;
            //temp = a;
            //a = b;
            //b=temp;

            a = a + b;
            b = a - b;
            a = a - b;
            
            Console.WriteLine($"After swap a: {a}, b: {b}");
        }

        public static void CopyString()
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter Second string");
            string str2 = Console.ReadLine();

            string str3 = str1 + str2;
            Console.WriteLine($"copied string : {str3}");
        }

        public static void DivNums()
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = int.Parse(Console.ReadLine());

            int quot = num1 / num2;
            int rem = num1 % num2;

            Console.WriteLine($"rem : {rem}, quotient : {quot}");
        }

        public static void PrintNames()
        {
            Console.WriteLine("Enter user name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(name);
            }
        }


    }
}
