using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day2
{
    internal class ArrayDemo
    {
        public static void singleDimensionArray() {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            //Console.WriteLine(arr[5]);

            Console.WriteLine(arr.Length);

            Array.Sort(arr); // sorts in ascending order
            Array.Reverse(arr);  
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            // find single dimension or multi dimension
            Console.WriteLine(arr.Rank);
        }

        public static void singleDimensionArray2()
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            foreach (int i in arr) Console.WriteLine(i);
        }

        public static void multiDimensionArray()
        {
            int[,] arr =
            {
                { 10,20,30,40},
                { 50,60,70,80}, 
                { 90,100,110,120}
            };

            // how to print specific value
            Console.WriteLine(arr[1,1]);

            // how to find total number of items
            Console.WriteLine(arr.Length);

            // how to find length of rows
            Console.WriteLine(arr.GetLength(1));  // 0 => row, 1=> columns

            for (int i = 0;i < arr.GetLength(0);i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }

            foreach (int i in arr) Console.WriteLine(i);   
            
        }


        public static void multiDimensionArray2()
        {
            int[,] arr = new int[2, 3];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void jaggedArray()
        {
            // row size is fixed, column size is not fixed
            int[][] arr = new int[5][];

            arr[0]= new int[3] {1,2,3};
            arr[1] = new int[2] { 4,5 };
            arr[2] = new int[4] { 6,7,8,9 };
            arr[3] = new int[0] { };
            arr[4] = new int[1] { 10 };
          
            foreach (var i in arr){
                foreach (var j in i)
                {
                    Console.Write(j);
                    Console.Write(" ");
                }
                Console.WriteLine();    
            }
        }


        // converting value type to reference type = boxing
        // reference to value type= unboxing
        // value type => all the primitive data type (ex : datatypes,struct,enum)  => value types stored in stack memory
        // reference type => object (unlimited size) (ex: class, interface, delegates) => ref type stored in heap memory
        public static void boxingDemo() {
            int i = 10;
            object ob = i;
            Console.WriteLine(ob);

            int k = (int)ob;
            Console.WriteLine(k);
        }


        //using nullable types we can assign null value for value data type
        // it is achieved by using question mark symbol
        public static void nullableDemo()
        {
            int? i = null;
           
            Console.WriteLine(i);
           
        }

        /// <summary>
        /// this method demonstrates pointer demo,
        /// also unsafe keyword demo
        /// </summary>
        public unsafe static void poniterDemo()
        {
            int x = 100;
            int *p = &x;

            Console.WriteLine(*p);

        }
    }
}
