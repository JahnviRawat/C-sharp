using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherClass
{
    public class Class1
    {
        public int MyProperty { get; set; }
        public int MyProperty1 { get; set; }

        [Obsolete("This method is deprecated please use Method1New() instead")]
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method1New()
        {
            Console.WriteLine("Method 1");
        }
        private void Method2()
        {
            Console.WriteLine("Method 2");
        }
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum: " + (a+b));
        }
        public void Sub(int a , int b)
        {
            Console.WriteLine("Sub: " + (a - b));
        }
    }

    public class Class2 { }
    public class Class3 { }
}
