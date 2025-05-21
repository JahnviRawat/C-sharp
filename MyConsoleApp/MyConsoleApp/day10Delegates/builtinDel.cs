using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day10Delegates
{
    internal class builtinDel
    {
        //delegate void myDelm();

        public void Add()
        {
            Console.WriteLine("Add called");
        }

        public void sub(int x, int y)
        {
            Console.WriteLine("sub called");
        }

        public string multiply(int x, int y)
        {
            return "multiplication is: " + x * y;
        }
        public double factorial()
        {
            return 10.5;
        }
        public void display()
        {

            // ACTION IS VOID, IT DOESN'T SUPPORT RETURN TYPE


            Action ob = Add;
            ob.Invoke();

            Action<int, int > ob1 = sub;
            ob1.Invoke(20, 10);

            Func<int,int,string> ob3 = multiply;
            var res = ob3.Invoke(20, 10);
            Console.WriteLine(res);

            Func<double> ob4 = factorial;
            var res1 = ob4.Invoke();
            Console.WriteLine(res1);
        }
    }
}
