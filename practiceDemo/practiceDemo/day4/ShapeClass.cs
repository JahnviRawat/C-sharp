using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace practiceDemo.day4
{
    internal abstract class ShapeClass
    {
        public  abstract void calculateArea();
    }
    internal class CircleClass : ShapeClass
    {
        public int radius { get; set; }
        double pi = 3.14;
        public override void calculateArea()
        {
            Console.WriteLine($"Area of Circle: {2*pi* radius}  ");
        }
    }

    internal class RectangleClass : ShapeClass
    {
        public int length { get; set; }
        public int width { get; set; }
        public override void calculateArea()
        {
            Console.WriteLine($"Area of Rectangle: {length * width}  ");
        }
    }

    internal class TriangleClass : ShapeClass
    {
        public int base1 { get; set; }
        public int heigth { get; set; }

        public override void calculateArea()
        {
            Console.WriteLine($"Area of Tiangle: {base1 * heigth}  ");
        }
    }

}
