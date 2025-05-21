using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day3
{
    public class ClassA
    {
        public void AFun()
        {
            Console.WriteLine("Function of class A");
        }
    }

    public class classB : ClassA
    {
        public void BFun()
        {
            Console.WriteLine("Function of class B");
        }
    }

    public class classC : classB
    {
        public void CFun()
        {
            Console.WriteLine("Function of class C");
        }
    }
}
