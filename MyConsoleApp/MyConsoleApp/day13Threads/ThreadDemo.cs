using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyConsoleApp.day13Threads
{
    internal class ThreadDemo
    {
        public void method1(object ob1)
        {
            for (int i = 0; i < 10; i++)
            {
               
                Console.WriteLine("Method 1 Called : " + i + " : " + ob1);
                Thread.Sleep(1000); // 1sec
            }
        }

        public void method2(object ob1)
        {
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Method 2 Called : " + i + " : " + ob1);
                Thread.Sleep(1000); // 1sec
            }
        }

        public void m1()
        {

            Thread t2 = new Thread(m2);
            t2.Name = "Second";

            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(1000); // 1sec
                Console.WriteLine("M1 Called :" + i);

                if (i == 5)
                {
                    t2.Start();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("M2 started");
                }
                else if (i == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    t2.Suspend();
                    Console.WriteLine("M2 Paused");

                }
                else if (i == 15)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    t2.Resume();
                    Console.WriteLine("M2 Resumed");
                }
                else if (i == 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    t2.Abort();
                    Console.WriteLine("M2 Aborted");
                }
                else if (i == 25)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("M1 Aborted");
                    Thread.CurrentThread.Abort();
                }
            }
            Console.WriteLine("End process");
        }

        public static void m2()
        {
            for (int i = 0; i >= 0; i++)
            {
                Thread.Sleep(1000); // 1sec
                Console.WriteLine("M2 Called :" + i);
            }
        }


        public void filehandling()
        {
            // only one thread can use this code

            //Monitor.Enter(this);
            //for(int i = 0;i < 10; i++)
            //{
            //    Console.WriteLine(Thread.CurrentThread.Name + " : " + i);
            //    Thread.Sleep(1000);
            //}
            //Monitor.Exit(this);


            // Internally this is using Monitor.Enter
            // simplified version of monitor
            lock (this) {         // Only one thread can enter inside
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " : " + i);
                    Thread.Sleep(1000);
                }
            } 

        }

        
    }
}
