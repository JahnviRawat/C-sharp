using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day7
{
    internal class Product//: IComparable
    {
        public int id { get; set; }
        public  string pName { get; set; }
        public int price { get; set; }

        //public int CompareTo(object obj)
        //{
        //    Product p = (Product)obj;
        //    //return p.id.CompareTo(id); //-->  desc
        //    return id.CompareTo(p.id);  // --> asc
        //}
    }
}
