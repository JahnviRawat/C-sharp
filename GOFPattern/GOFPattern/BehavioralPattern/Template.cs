using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFPattern.BehavioralPattern
{
    internal abstract class books
    {
        public void ProcessData()
        {

        }

        public abstract void selectBook();
        public abstract void makePayment();
        public abstract void deliver();
        

    }
    class onlineDelivery : books
    {

        public override void selectBook()
        {
            Console.WriteLine("Select Books");
        }
        public override void makePayment()
        {
            Console.WriteLine("Make payment");
        }
        public override void deliver()
        {
            Console.WriteLine("Send pdf");
        }

    }

    class physicalDelivery : books
    {
        public override void selectBook()
        {
            Console.WriteLine("Select Books");
        }
        public override void makePayment()
        {
            Console.WriteLine("Make payment");
        }
        public override void deliver()
        {
            Console.WriteLine("Send Book to address");
        }

    }
}
