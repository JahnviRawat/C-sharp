using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day4
{
    internal interface IShape
    {
         void calculateArea();
    }

    public class Circle: IShape
    {
        public int radius { get; set; }
        double pi = 3.14;
        public void calculateArea()
        {
            Console.WriteLine(2*pi*radius);
        }
    }

    public class Rectangle : IShape
    {
        public int length { get; set; }
        public int width { get; set; }
        public void calculateArea()
        {
            Console.WriteLine(length * width);
        }
    }
}
