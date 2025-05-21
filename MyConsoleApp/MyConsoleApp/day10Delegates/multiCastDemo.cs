using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyConsoleApp.day10Delegates
{
    internal class multiCastDemo
    {
        public delegate void multiDel();
        public delegate string mydbDel();
        mydbDel ob;

        delegate void myGenDel<T>(T x, T y);
        public void swap<T>(T x , T y)
        {
            T c = x;
            x = y;
            y = c;

            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public void callGen()
        {
            myGenDel<int> ob = swap;
            ob.Invoke(10, 20);
        }
        
        public void m1()
        {
            Console.WriteLine("M1 demo");
        }
        public void m2()
        {
            Console.WriteLine("M2 demo");
        }

        public string mydbMethod()
        {
            Thread.Sleep(5000);
            string str = "Hello";
            return str;
        }

        public void display()
        {
            //multiDel ob = m1;
            //ob += m2;
            //multiDel ob2 = ob;
            ////ob2 -= m1;
            //ob2.Invoke();

            //multiDel ob = m1;
            //multiDel ob2 = m2;
            //multiDel ob3 = ob + ob2;
            ////ob2 -= m1;
            //ob3.Invoke();

            //mydbDel ob = mydbMethod;
            //Console.WriteLine(ob.Invoke());
            //m1();

            ob = mydbMethod;
            var res = ob.BeginInvoke(showOutput, null);
            //Console.WriteLine(res);
            m1();

        }

        public void showOutput(IAsyncResult ar)
        {
            
            var res = ob.EndInvoke(ar);
            Console.WriteLine(res);
        }
    }
}
