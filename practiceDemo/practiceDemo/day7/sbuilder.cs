using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day7
{
    public class carDemo

    {

        public string carname { get; set; }

        public bool rooftop { get; set; }

        public bool withac { get; set; }

        public string color { get; set; }

        public int price { get; set; }



        public void display()

        {

            Console.WriteLine("------------------------------");

            Console.WriteLine($"Car name : {carname}");

            Console.WriteLine($"Car color : {color}");

            Console.WriteLine($"Sunroof : {(rooftop ? "Available" : "Not available")}");

            Console.WriteLine($"Car AC : {(withac ? "Available" : "Not available")}");

            Console.WriteLine($"Price of car : {price}");

            Console.WriteLine("------------------------------");

        }

    }

    internal class Builder_Demo

    {

        carDemo c = new carDemo();



        public Builder_Demo CarName(string carname)

        {

            c.carname = carname;

            return this;

        }



        public Builder_Demo CarColor(string color)

        {

            c.color = color;

            return this;

        }



        public Builder_Demo RoofTop(bool rooftop)

        {

            c.rooftop = rooftop;

            return this;

        }



        public Builder_Demo WithAC(bool withac)

        {

            c.withac = withac;

            return this;

        }

        public Builder_Demo Price(int price)

        {

            c.price = price;

            return this;

        }

        public carDemo buildcar()

        {

            return c;

        }

    }
}
