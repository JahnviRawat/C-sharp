using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day6
{
    internal class collectionsAssgn
    {
        public void HashCountry(int key)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "India");
            hashtable.Add(2, "USA");
            hashtable.Add(3, "UK");

            if (hashtable.ContainsKey(key))
            {
                Console.WriteLine(hashtable[key]);
            }
            else
            {
                Console.WriteLine("Key does not found");
            }
        }

    }

    class custDetails
    {

        List<customerList> list = new List<customerList>()
        {
            new customerList() { custId = 100, custName = "Morvi", Address = "Bangalore", Dob = new DateTime(year:2025,month:05,day:10) },
            new customerList() { custId = 101, custName = "Jahnvi", Address = "Haridwar", Dob = new DateTime(year:2024,month:07,day:1) },
            new customerList() { custId = 102, custName = "Mansi", Address = "Delhi", Dob = new DateTime(year:2024,month:02,day:14) }
        };

        public void displayDetails()
        {
            foreach (customerList customer in list)
            {
                Console.WriteLine(customer.custId + customer.custName + customer.Address + customer.Dob);
            }
        }

        public void getReport(DateTime d1, DateTime d2)
        {
            foreach (customerList customer in list)
            {
                if (customer.Dob.Day > d1.Day && customer.Dob.Day < d2.Day)
                {
                    Console.WriteLine(customer.custName);
                }
            }
        }

        public void customerDetId(int id)
        {
            foreach (customerList customer in list)
            {
                if (customer.custId == id)
                {
                    Console.WriteLine(customer.custName);
                }
            }
        }
    }
}
