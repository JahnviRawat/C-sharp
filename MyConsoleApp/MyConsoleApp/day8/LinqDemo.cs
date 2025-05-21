using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MyConsoleApp.day6;
using MyConsoleApp.day7;

namespace MyConsoleApp.day8
{
    internal class LinqDemo
    {
        public void demo()
        {
            string[] st = { "India", "Usa", "Uk", "Australia" };
            var res = from t in st where t.Length < 5 select t;
            foreach (var t in res)
            {
                Console.WriteLine(t);
            }
        }

        public void demo2() {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            var res = from t in arr where t.IsEven() select t;
            foreach(var t in res) {  Console.WriteLine(t); }
        }
        public void demo3()
        {
            List<Product> list = new List<Product>()
            {
                new Product() { id = 100, pName = "Books", price=200},
                new Product() { id = 110, pName = "Diary", price=150},
                new Product() { id = 110, pName = "Bookmark", price=100},
                new Product() { id = 102, pName = "Pen", price=50}
            };

            //deferred query
            var res = from t in list where t.price > 50 orderby t.price descending select new {t.pName,t.price};

            list.Add(new Product() { id = 130, pName = "Marker", price = 120 });
            foreach (var t in res) { Console.WriteLine(t.pName + " - " + t.price); }

            Console.WriteLine("----------------");

            var res1 = from t in list where t.price > 90 && t.price < 200 orderby t.price descending select new { productName = t.pName, productprice = t.price };

            foreach (var t in res1) { Console.WriteLine(t.productName + " - " +  t.productprice); }

            //Immediatequery
            Console.WriteLine("----------------");

            var res4 = (from t in list where t.price > 50 orderby t.price descending select new { t.pName, t.price }).ToList();

            list.Add(new Product() { id = 135, pName = "Highlighter", price = 130 });
            foreach (var t in res4) { Console.WriteLine(t.pName + " - " + t.price); }
        }

        public void demo4()
        {
            
            List<Product> list = new List<Product>()
            {
                new Product() { id = 100, pName = "Books", price=200},
                new Product() { id = 110, pName = "Diary", price=150},
                new Product() { id = 110, pName = "Bookmark", price=100},
                new Product() { id = 102, pName = "Pen", price=50}
            };

            // query expression method
            //var res = from t in list where t.price > 50 orderby t.price descending select new { t.pName, t.price };

            //lambda expression method 
            //var res = list.Where(t=> t.price > 50);

            //partition: take,skip,tajewhile,skipwhile
            //var res = list.Take(3);
            //var res = list.Skip(3);
            //var res = list.TakeWhile(t=> t.price != 50);  -> print until you find 50

            // supports chainning
            //var res = list.SkipWhile(t => t.price != 150);  //-> skip until you find 150 then print from there
            //var res = list.SkipWhile(t => t.price != 150).TakeWhile(t => t.price != 50);

            //var res = list.Take(3).Where(t => t.price > 50).Skip(1);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.pName + " - " + item.price);
            //}

            // first 2 records , show price greater than 50 print descending order
            var res = list.Take(2).Where(t=>t.price>50).OrderByDescending(t=>t.price);
            foreach (var item in res)
            {
                Console.WriteLine(item.pName + " - " + item.price);
            }

        }

        public void demo5()
        {
            //int[] a = { 1, 2, 3, 4, 5, 6, 7, 8,6 };
            //int[] b = { 6, 7, 8, 9, 10, 11, 12 };
            ////var res = a.Except(b);
            ////var res = a.Intersect(b);
            ////var res = a.Union(b);
            //var res = a.Distinct();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //================================================================================
            // any all contains
            List<Product> list = new List<Product>()
            {
                new Product() { id = 100, pName = "Books", price=200},
                new Product() { id = 110, pName = "Diary", price=150},
                new Product() { id = 110, pName = "Bookmark", price=100},
                new Product() { id = 102, pName = "Pen", price=50}
            };

            //var res = list.Any(t=> t.price>50);
            //var res = list.All(t => t.price > 60);
            var r = list.Find(t=> t.id == 100);
            var res = list.Contains(r);
            Console.WriteLine(res);

            //================================================================================
            //plinq

            //var res = from t in list.AsParallel() select t;
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //================================================================================
            //ienumerable: working with temporary object
            // (inmemory type of object)
            //arrays,lists,collection classes, datasets

            //iqueryable : working with databases
            //not inmemory (permanent data)
            //it will generate sql query
            //var res = from t in list.AsQueryable() select t;

        }

    }

}
