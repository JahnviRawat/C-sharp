using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day6
{
   
    class x1
    {
        public void hi()
        {
            int k = 10;

            Console.WriteLine("Hi called");
        }
    }
    internal class languageFeature
    {
        public void display()
        {
            
            x1 ob = new x1();
            ob.hi();

            global::x1 obb = new global::x1();
            obb.hi();
        }

        public Tuple<int, string> getData()
        {
            
            string name = "Morvi";
            int age = 22;

            Tuple<int, string> t = new Tuple<int, string>(age, name);
            return t;
        }
    }

    static class myExls
    {
        public static bool IsEven(this int x)
        {
            return x % 2 == 0;
        }
        public static int toInteger(this string x)
        {
            return int.Parse(x);
        }
        public static int addFunc(this global::x1 ob, int p, int q)
        {

            return p + q;
        }
    }

}
#pragma warning disable
class x1
{ 
    int x;

//#pragma warning restore

    public void hi()
    {
        Console.WriteLine("Hi called");
    }
}
