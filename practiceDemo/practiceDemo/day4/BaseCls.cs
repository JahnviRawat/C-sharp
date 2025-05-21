using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day4
{
    internal class BaseCls
    {
        public BaseCls(int x) { Console.WriteLine("Base class: "+x); }
    }

    internal class DerivedCls : BaseCls
    {
        public DerivedCls(int x) : base(100) 
        { 
            Console.WriteLine("Derived class: " + x); 
        }
    }

}
