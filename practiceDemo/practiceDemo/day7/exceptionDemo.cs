
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day7
{
    internal class exceptionDemo
    {
        public void excpDemo()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c= a+b;

            try
            {
                Console.WriteLine(arr[10]);
            }
            catch (IndexOutOfRangeException e)
            { 
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(OverflowException e) {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            
        }
    }

    class StringClass
    {
        

        public void stringDemo(string str)
        {
            Console.WriteLine(str.Reverse().ToArray());
        }

        public int countChar(string str, char ch) {
            int count = 0;
            foreach (char c in str)
            {
                if(c == ch)
                {
                    count++;
                }
            }
            return count;
        }

        public void formatString()
        {
            string name = "jahnvi rawat";
            string[] str = name.Split(' ');

            Console.WriteLine($"FirstName: {str[0]} LastName: {str[1]}");

            int count = 0;
            foreach (char c in name)
            {
                if (c != ' ')
                {
                    count++;
                }
            }
            Console.WriteLine("count: " + count);
        }

        public void compareStrings()
        {
            string str = "morvi";
            string str1 = "jahnvi";
            string str2 = str;

            Console.WriteLine(str1.CompareTo(str));
            //Console.WriteLine(str.e);

            Console.WriteLine(str2.Equals(str));

        }

        public void stringBuilderDemo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("India ");
            sb.Append("the ");
            sb.Append("next global leader");
            Console.WriteLine(sb);
        }

        public void stringBuilderDemo2()
        {
            StringBuilder sb = new StringBuilder();
            string[] str = { "hello ", "World ", "welcome " };
            foreach (string str2 in str)
            {
                sb.Append(str2);
            }

            Console.WriteLine(sb);
        }

        public void removeOccStringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello@world");

            sb.Replace("l", "");

            //sb.Replace("@", " ");

            //sb.Insert(9, "l");


            //for (int i = 0; i <= sb.Length; i++) {
            //    if (sb[i] == 'l') {
            //        sb.Remove(i, i+1);
            //    }
            //}
            Console.WriteLine(sb);
        }
    }
}
