using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace TplDEmo
{
    internal class parallelDemo
    {
        public void demo1()
        {
            for (int i = 0; i <= 3; i++) {
                Task.Run(() =>
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                    Console.WriteLine("Task1 goes here");
                }); // a piece of code run independently or asynchronously
            }

            for (int i = 0; i <= 3; i++)
            {
                Task.Run(() =>
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                    Console.WriteLine("Task2 goes here");
                }); // a piece of code run independently or asynchronously
            }

            for (int i = 0; i <= 3; i++)
            {
                Task.Run(() =>
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                    Console.WriteLine("Task3 goes here");
                }); // a piece of code run independently or asynchronously
            }
        }

        public void Method2()
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Method 2 is running");
                Thread.Sleep(1000);
            }
        }
        public static int demo4(int x, int y)
        {
            //Console.WriteLine("sum is : " + x + y);
            return x + y;
        }

        public void demo2()
        {
            // run task using delegate 
            // Task.run() // this code will run immediately
            Action a = delegate ()
            {
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine("Method 1 is running");
                    Thread.Sleep(1000);
                }
            };

            Task t1 = new Task(a);  // will be executed when you use the task method
            t1.Start();


            Action b = new Action(Method2);
            Task t2 = new Task(b);  // will be executed when you use the task method
            t2.Start();

           //Action<int, int> c = demo3;
           Action<int, int> c = (x, y) => { Console.WriteLine("Sum is " + x + y); };
            Task t3 = new Task(()=> c(10,20));  // will be executed when you use the task method
            t2.Start();

            Func<int,int,string> d = (x,y) => {  return "Sum is"+ x+y; };
            Task t4 = new Task(()=> d(10,20));
        }

       

        public static void NonParallelMethod()
        {
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine("TID={0}, i={1}",
                    Thread.CurrentThread.ManagedThreadId,
                    i);


                Thread.Sleep(500);
            }
        }


        public static void ParallelMethod()
        {
            Parallel.For(0, 16, i =>
            {
                Console.WriteLine("TID={0}, i={1}",
                    Thread.CurrentThread.ManagedThreadId,
                    i);


                Thread.Sleep(500);
            });
        }

        public void demo5()
        {

            Task t1 = Task.Run(() => {
                for (int i = 0; i <= 3; i++)
                {

                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                    Console.WriteLine("Task1 goes here");
                }
            });

            //t1.Wait();

            Task t2 = Task.Run(() => {
                for (int i = 0; i <= 3; i++)
                {

                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                    Console.WriteLine("Task2 goes here");
                }
            });

            Task.WaitAll(t1,t2);
            Task t3 = Task.Run(() => {
                for (int i = 0; i <= 3; i++)
                {

                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                    Console.WriteLine("Task3 goes here");
                }
            });

            Console.Read();
        }

        public void demo6()
        {
            int x = 0;
            Task res = Task.Run(() =>
             {
                 int a = 5;
                 int b = 6;
                 x = a + b;
             });

            //res.Wait();
            
            Console.WriteLine(res.IsCompleted);
           
            Console.WriteLine("Sum is : " + x);
        }

        public void demo7()
        {
            Task.Run(() =>
            {
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine("Task1 goes here");
                    Thread.Sleep(1000);
                }
            }).GetAwaiter().OnCompleted(() =>
            {
                Console.WriteLine(" res1 completed");
            });

            Console.Read();
        }

        public void demo8()
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Task1 goes here");
                    Thread.Sleep(1000);
                }
            }).ContinueWith(t =>
            {
                Task.Run(() =>
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Task2 goes here");
                        Thread.Sleep(1000);
                    }

                });
            }).ContinueWith(t =>
            {
                Task.Run(() =>
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Task3 goes here");
                        Thread.Sleep(1000);
                    }

                });
            }).GetAwaiter().OnCompleted(() =>
            {
                Console.WriteLine("Task Ended");
            });
            //Console.Read();
        }

        public void demo9()
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Task1 goes here");
                    Thread.Sleep(1000);
                }
            }).ContinueWith(t =>
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Task2 goes here");
                    Thread.Sleep(1000);
                }
            }).ContinueWith(t =>
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Task3 goes here");
                    Thread.Sleep(1000);
                }

            }).GetAwaiter().OnCompleted(() =>
            {
                Console.WriteLine("Task Ended");
            });
            //Console.Read();
        }

        public void add()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Add called");
        }
        public async void demo10() {

            var res = 0;
            await Task.Run(() =>
            {
                add();
            });

            Console.WriteLine("Add completed");
        }
    }
}
