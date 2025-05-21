using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day4
{
    internal class Vehicle
    {
        public virtual void drive()
        {
            Console.WriteLine("Base Class Drive");
        }
    }

    internal class Car : Vehicle
    {
        public override void drive()
        {
            Console.WriteLine("Car Class Drive");
        }
    }

    internal class Bike : Vehicle
    {
        public override void drive()
        {
            Console.WriteLine("Bike Class Drive");
        }
    }
}
