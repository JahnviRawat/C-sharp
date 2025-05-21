using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using MyConsoleApp.day4;


namespace MyConsoleApp.day7
{
    internal class CollectionDemo
    {
        public void ArrayListDemo()
        {
            ArrayList arr = new ArrayList();
            arr.Add("India");
            arr.Add("Usa");
            arr.Add("UK");

            // access values;
            Console.WriteLine("Value at 2nd position: " + arr[1]);

            Console.WriteLine("-----------");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            // find total items 
            Console.WriteLine("Total items: " + arr.Count);

            // insert values at specific index
            Console.WriteLine("------------");
            arr.Insert(2, "Germany");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


        }

        public void ArrayListDemo2()
        {
            // no. of items arraylist can store
            ArrayList arr = new ArrayList(10);
            arr.Add(1);

            Console.WriteLine(arr.Capacity);
            arr.Capacity = 15;
            Console.WriteLine(arr.Capacity);
            arr.TrimToSize();
            Console.WriteLine(arr.Capacity);
        }

        public void ArrayListDemo3()
        {
            // store product details 
            ArrayList arr = new ArrayList();
            Product prod = new Product() { id = 100, pName = "Books", price = 200 };
            arr.Add(prod);

            Product prod1 = new Product() { id = 101, pName = "Diary", price = 250 };
            arr.Add(prod1);

            arr.Add(new Product() { id = 102, pName = "Pen", price = 50 });
            foreach (Product item in arr)
            {
                Console.WriteLine(item.id + item.pName + item.price);
                Console.WriteLine("-------------------");
            }
        }

        public void ArrayListDemo4()
        {

            // collection initializer 

            ArrayList arr = new ArrayList()
            {
                new Product() { id = 100, pName = "Books", price=200},
                new Product() { id = 110, pName = "Diary", price=250},
                new Product() { id = 102, pName = "Pen", price=50}
            };

            sortProduct sortOb = new sortProduct();
            arr.Sort(sortOb);
            foreach (Product item in arr)
            {
                Console.WriteLine(item.id + item.pName + item.price);
                Console.WriteLine("-------------------");
            }
        }

        public void ArrayListDemo5()
        {
            ArrayList arr = new ArrayList();
            arr.Add(4);
            arr.Add(102);
            arr.Add(92);
            arr.Add(100);
            arr.Add(34);

            arr.Sort();
            foreach (var item in arr) { Console.WriteLine(item); }
        }

        public void HashTableDemo()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "India");
            hashtable.Add(2, "Canada");
            hashtable.Add(3, "USA");
            hashtable.Add(4, "UK");

            SortedList sortedList = new SortedList(hashtable);

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        public void StackDemo()
        {
            Stack stack = new Stack();
            stack.Push("Google");
            stack.Push("Youtube");
            stack.Push("facebook");
            
            foreach (var item in stack) { Console.WriteLine(item); }

            Console.WriteLine("-------- Removed Item");
            Console.WriteLine(stack.Pop());  // remove + print

            Console.WriteLine("--------");
            foreach (var item in stack) { Console.WriteLine(item); }

            Console.WriteLine("--------");
            Console.WriteLine(stack.Peek()); // prints item at top
        }

        public void QueueDemo()
        {
            Queue queue = new Queue();
            queue.Enqueue("raj");
            queue.Enqueue("ajay");
            queue.Enqueue("rohan");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
        }

        public void listDemo()
        {
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);
            //Console.WriteLine(Convert.ToInt32(arrayList[1]) + Convert.ToInt32(arrayList[2]));
            //Console.WriteLine(arrayList[1] + arrayList[2]);

            List<int> list = new List<int>();
           list.Add(110);
            list.Add(2200);
            list.Add(390);
            list.Add(40);
            list.Add(567);

            //Console.WriteLine(list[1] + list[2]);

            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] > 120)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
        
        public void listDemo1()
        {
            List<Product> list = new List<Product>()
            {
                new Product() { id = 100, pName = "Books", price=200},
                new Product() { id = 110, pName = "Diary", price=250},
                new Product() { id = 102, pName = "Pen", price=50}
            };

            foreach (Product item in list)
            {
                if(item.price > 120)
                {
                    Console.WriteLine(item.pName);
                }
            }
        }

        public void disctionaryDemo()
        {
            Dictionary<int,string> dic = new Dictionary<int,string>();
            dic.Add(1, "Morvi");
            dic.Add(2, "Mansi");

            foreach(var item in dic)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

    }

    class sortProduct : IComparer
    {
        public int Compare(object x, object y)
        {
            Product p1 = (Product)x;
            Product p2 = (Product)y;

            return p1.id.CompareTo(p2.id);
        }
    }
}
