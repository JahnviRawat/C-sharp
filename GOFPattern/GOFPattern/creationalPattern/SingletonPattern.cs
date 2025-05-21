using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFPattern.creationalPattern
{
    // how to create single object, irrespective of no. of users using class instances
    // scenario : share databse connections, 
    // any configuration which is common for all the users
 

    // how to create singleton object 
    // 1. the class is sealed  => no object , no inheritance
    // 2. Make the class constructor private 
    // 3. Create Static property to generate instance 
    internal class SingletonPattern
    {
        private SingletonPattern() { }

        static SingletonPattern s = null;
        // return the instance 
        public static SingletonPattern GetInstance { 
            get {
                if (s == null)
                {
                    s = new SingletonPattern();
                    return s;
                }
                else
                {
                    return s;
                }
            } 
        }

        public void Method()
        {
            Console.WriteLine("database code triggered");
        }

  
    }
}
