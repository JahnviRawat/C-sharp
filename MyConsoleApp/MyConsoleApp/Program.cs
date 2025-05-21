using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyConsoleApp.day1;
using MyConsoleApp.day2;
using MyConsoleApp.day3;
using MyConsoleApp.day4;
using MyClassLib;
using MathLibrary;
using MyConsoleApp.day6;
using MyConsoleApp.day7;
using MyConsoleApp.day8;
using MyConsoleApp.dayFile;
using System.IO;
using MyConsoleApp.day10Delegates;
using System.Security.Cryptography.X509Certificates;
using static MyConsoleApp.day10Delegates.delRealtime;
using MyConsoleApp.day13Threads;
using System.Threading;

namespace MyConsoleApp.day6
    
{
    internal class Program
    {
        static Semaphore s = new Semaphore(3,5);
        //static AutoResetEvent handle = new AutoResetEvent(false);

        static EventWaitHandle handle = new ManualResetEvent(false);
        //public static bool Mylogic(int x)
        //{
        //    return x > 50;
        //}
        static void Main(string[] args)
        {

            #region // code to call constructor
            //firstClass.Greatest();
            //Console.WriteLine("Hello World !!!");
            //Console.Read();


            //demo1.greatestOfThree();
            //demo1.empDetails();
            //demo1.factorial();
            //demo1.sumOf10Nums();
            //demo1.SwapNums();
            //demo1.CopyString();
            //demo1.DivNums();
            //demo1.PrintNames();
            //    string ans;
            //    do
            //    {
            //        Console.WriteLine("Do you want to continue ? Yes / NO");
            //        ans = Console.ReadLine();

            //        Console.WriteLine("Enter the program number:- 1: greatestOfThree(), 2: empDetails(), 3: factorial(), 4: sumOf10Nums(), 5: SwapNums(), 6: CopyString(), 7: DivNums(), 8: PrintNames() ");
            //        int ch = int.Parse(Console.ReadLine());
            //        switch (ch)
            //        {
            //            case 1:
            //                demo1.greatestOfThree();
            //                break;

            //            case 2:
            //                demo1.empDetails();
            //                break;

            //            case 3:
            //                demo1.factorial();
            //                break;

            //            case 4:
            //                demo1.sumOf10Nums();
            //                break;
            //            case 5:
            //                demo1.SwapNums();
            //                break;

            //            case 6:
            //                demo1.CopyString();
            //                break;
            //            case 7:
            //                demo1.DivNums();
            //                break;
            //            case 8:
            //                demo1.PrintNames();
            //                break;

            //        }
            //    }
            //    while (ans == "yes");


            //int m = 100;
            //ParamDemo.refTypeDemo(ref m);
            //Console.WriteLine("m: ",m);

            //int sum, prod;
            //ParamDemo.outDemo(10,20,out sum, out prod);
            //Console.WriteLine($"sum : {sum}, Product: {prod}");

            //ParamDemo.optionalDemo(b:10);

            //int[] arr = {1,2,3,4,5,6,7,8,9};
            ////ParamDemo.paramArrayDemo(arr);

            //ParamDemo.paramArrayDemo(10,20,30,40,50);

            //ArrayDemo.poniterDemo();

            //Login ob= new Login();
            //ob.UserName = "Morvi";
            //ob.Password = "123";
            //ob.Validate();

            //Employee employee = new Employee();
            //employee.age = 20;
            //Console.WriteLine(employee.age);

            //employee.name = Console.ReadLine();
            //Console.WriteLine(employee.name);

            //employee.address=Console.ReadLine();
            //Console.WriteLine(employee.address);

            //employee.id = "emp1";
            //Console.WriteLine(employee.id);


            //object initializer
            //Ipl ipl = new Ipl() { tName = "RCB" , captain = "Virat", budget= 10};

            //ipl.printTeam();

            //movies movies = new movies() { movieId = 1 , movieName = "ddlj", actor= "srk", actress="kajol"};
            //movies movies1 = new movies() { movieId = 2, movieName = "jnmd", actor = "hrithik", actress = "katrina" };
            //movies.printMovie();
            //movies.printMovie();


            //ChildClass childClass = new ChildClass();
            //childClass.hi();

            //ChildClass childClass1 = new ChildClass();
            //childClass1.hi();

            //MyCls ob = new MyCls();
            //ob.helloWorld();

            //mathClass mathClass = new mathClass();
            //Console.WriteLine("Enter first number");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second number");
            //int num2 = int.Parse(Console.ReadLine());
            //mathClass.addFun(num1, num2);
            //mathClass.subFun(num1, num2);

            //StaticPolyDemo spd = new StaticPolyDemo();
            //spd.add(5,10);
            //spd.add(2.3f, 10.734f);
            //spd.add(5, 10.614);

            //SqlDb sqlDbob;

            //SqlDb sqlDbob = new SqlDb();
            //sqlDbob.connect(); // read from sql
            //sqlDbob.filter();

            //Console.WriteLine("----------------");
            //// read from oracle 
            //sqlDbob = new OracleDb();  // sqlDb is an object od SqlDb class but it is reinitalised to OracleDb class
            //sqlDbob.connect();
            //sqlDbob.filter();

            //Console.WriteLine("----------------");
            //// read from MySqlDb 
            //sqlDbob = new MySqlDb();  // sqlDb is an object od SqlDb class but it is reinitalised to MySqlDb class
            //sqlDbob.connect();
            //sqlDbob.filter();

            #endregion

            #region // IMath interface code
            //IMath2 mathClass = new MathClass();
            //mathClass.Add(5, 2);
            //MathClass mathClass = new MathClass();
            //mathClass.Sub(5, 2);
            //mathClass.multiply(5, 2);
            //mathClass.divide(5, 2);

            #endregion

            #region // day6
            //int k = 10;
            //Console.WriteLine(k.IsEven());

            //string st = "10";
            //Console.WriteLine(st.toInteger());

            //x1 ob = new x1();
            //Console.WriteLine(ob.addFunc(10, 20));

            //p1 ob = new p1();
            //ob.add();
            //ob.sub();
            //ob.Mul();
            //ob.Div();

            //languageFeature ob = new languageFeature();
            //Tuple <int,string> t = ob.getData();
            //Console.WriteLine(t.Item1);
            //Console.WriteLine(t.Item2);

            //dynamic d = "hi";
            //Console.WriteLine(d.StartsWith("h"));


            #endregion

            #region // Array collections

            //CollectionDemo  ob = new CollectionDemo();
            //ob.ArrayListDemo();

            //ob.ArrayListDemo2();

            //ob.ArrayListDemo3();

            //ob.ArrayListDemo4();

            //EmployeeList employeeList = new EmployeeList();
            //employeeList.AddEmployee(1, "Morvi","SDE");
            //employeeList.displayEmployee();
            //employeeList.AddEmployee(2, "Jahnvi", "ASDE");
            //employeeList.displayEmployee();

            //Console.WriteLine("-----------------");
            //IEnumerator e1 = employeeList.GetEnumerator();
            //e1.MoveNext();
            //Console.WriteLine(e1.Current);
            //e1.MoveNext() ;
            //Console.WriteLine(e1.Current);
            //e1.Reset();

            //Console.WriteLine("-----------------");
            //Console.WriteLine(employeeList[0]);
            //Console.WriteLine("-----------------");

            //foreach (EmployeeList employee in employeeList)
            //{
            //    Console.WriteLine(employee.id + employee.name + employee.dept);
            //}

            //ob.ArrayListDemo5();
            //ob.ArrayListDemo4();
            #endregion

            #region // hashtable, stack  collections
            //CollectionDemo ob = new CollectionDemo();
            //ob.HashTableDemo();
            //ob.StackDemo();
            //ob.QueueDemo();

            //ob.listDemo();
            //ob.listDemo1();
            //ob.disctionaryDemo();
            #endregion

            #region // Generics collections
            //GenDemo ob = new GenDemo();
            //ob.Swap<string>("Jahnvi", "Morvi");
            //ob.Swap("Jahnvi", "Morvi");
            //ob.Swap(10, 20);

            //Igen<string> gen = new GenDemo<string>();
            //gen.Swap("Morvi", "Jahnvi");

            //TestGen<Product> testGen = new TestGen<Product>();
            //TestGen<int> tg = new TestGen<int>();
            #endregion


            #region // linq

            //LinqDemo linqDemo = new LinqDemo();
            //linqDemo.demo();
            //linqDemo.demo2();
            //linqDemo.demo3();
            //linqDemo.demo4();
            //linqDemo.demo5();

            #endregion


            #region //copy constructor

            // Shallow copy, refernce type object changes both the places in shallow copy

            //Person p = new Person() { Name = "nobita", Age = 21, Address = new Address() { City = "Bangalore" } };
            //Person copyP = p.ShallowCopy();
            //p.Name = "Giyan";
            //p.Address.City = "hyd";
            //copyP.Age = 20;
            //Console.WriteLine($"{p.Name} {p.Age} {p.Address.City}");
            //Console.WriteLine($"{copyP.Name} {copyP.Age} {copyP.Address.City}");

            //============================================================================================================

            // Deep Copy , refernce type value doesnot changes in both the places
            // done through copy constructor
            //Person copyP = new Person(p);
            //p.Name = "Giyan";
            //p.Address.City = "hyd";
            //copyP.Age = 20;
            //Console.WriteLine($"{p.Name} {p.Age} {p.Address.City}");
            //Console.WriteLine($"{copyP.Name} {copyP.Age} {copyP.Address.City}");

            #endregion

            #region // binary tree, linked list

            //BinaryTree tree = new BinaryTree();
            //tree.Insert(50);
            //tree.Insert(30);
            //tree.Insert(70);
            //tree.Insert(20);
            //tree.Insert(40);
            //tree.Insert(60);
            //tree.Insert(80);

            //Console.WriteLine("Inorder Traversal:");
            //tree.InOrderTraversal(tree.Root);
            //Console.WriteLine("===============");
            //tree.PreOrderTraversal(tree.Root);
            //Console.WriteLine("================");
            //tree.PostOrderTraversal(tree.Root);


            ////==============================================================
            //listbox listbox = new listbox();
            //listbox.display();

            #endregion

            #region // fileDemo

            //FileDemo ob = new FileDemo();
            //ob.demo1();
            //ob.demo2();
            //ob.demo3();
            //ob.demo4();
            //ob.demo5();
            //ob.demo6();
            //ob.demo7();
            //ob.demo8();
            //ob.demo9();

            //ob.ReadData(new StreamReader("C:\\webD\\myFileDir\\hello.txt"));
            //ob.ReadData(new StringReader("Hello this is row stream"));

            #endregion

            #region // Dekegate Demo

            //myRealDel d = Mylogic;

            //myRealDel d = (x) => { return x > 50;  };

            // delRealtime ob = new delRealtime();
            //int[] k = { 10, 20, 30, 40, 50 , 60, 70, 80, 90,100,110,120,130,140,150};

            ////ob.filterData(k, (x) => { return x > 50; });

            //ob.filterData(k, (x) => x > 120 );
            //Console.WriteLine("---------------------------");
            //ob.filterData(k, (x) => x > 50 && x < 90);
            //Console.WriteLine("---------------------------");
            //ob.filterData(k, (x) => x > 50 && x < 80 || x > 120);

            //multiCastDemo ob = new multiCastDemo();
            //ob.display();
            //Console.Read();

            //ob.callGen();

            //builtinDel ob = new builtinDel();
            //ob.display();

            //Clientcls clientcls = new Clientcls();
            //clientcls.execute();
            #endregion

            #region // threads

            // Synchronous
            //ThreadDemo td = new ThreadDemo();
            //td.m1();
            //td.m2();


            //ThreadDemo td = new ThreadDemo();

            // Thread: is use to create thread
            //Thread t1 = new Thread(td.m1); // runs m1 in seperate thread
            //Thread t2 = new Thread(td.m2); // runs m1 in seperate thread

            //t1.Start();  // start the thread
            //t1.Suspend(); // pause the thread temporarily
            //t1.Resume(); // continue from where it's paused
            //t1.Abort(); // kill the thread
            //t1.join(); // other thread has to wait untill the t1 is completed

            //t1.Start();
            //t1.Join();
            //t2.Start();

            //Thread t1 = new Thread(td.m1);
            //t1.Name = "First";
            //t1.Start();

            // Monitor: Only one thread can access the respurces 
            // othher thread has to wait

            // Enter and Exit Method
            // Monitor.Enter: the lock is applied
            // Monitor.Exit: the lock is released

            //scenarios: printer, locking the record in database table: t1 edit operation t2 cannot delete record, 
            // File handling, 

            //Thread t1 = new Thread(td.filehandling);
            //t1.Name = "First";
            //Thread t2 = new Thread(td.filehandling);
            //t2.Name = "Second";
            //t1.Start();
            //t2.Start();


            #endregion


            #region // Mutex, threadpool, background thread
            //================================================================================

            // True -> owner ship : whichever the application runs first, they will hold the ownership
            // only who owns the ownership, they can release the lock 
            //Mutex m = new Mutex(true, "hi");

            //if (!m.WaitOne(1000))
            //{
            //    Console.WriteLine("Another instance is already Running");

            //}
            //else
            //{
            //    try
            //    {
            //        run();
            //    }
            //    finally
            //    {
            //        m.ReleaseMutex();

            //    }
            //}
            //Console.Read();

            //================================================================================

            // QueueUserWorkItem: use to access threadPool
            ThreadDemo ob = new ThreadDemo();

            //ThreadPool.QueueUserWorkItem(ob.method1, "First Pool Called");

            //ThreadPool.QueueUserWorkItem(ob.method2, "Second Pool Called");

            //Console.Read();

            //Thread t1 = new Thread(execute);
            //t1.IsBackground = false; // it will wait until user defined tag is completed 
            //t1.IsBackground = true; // it won't wait for the user defined tag to complete , it will close the application
            //t1.Start();
            //Console.WriteLine("Main function app Exited");
            //Console.Read();

            //for (int i = 0; i < 20; i++)
            //{
            //    new Thread(Program.DoSomthing).Start(i);

            //}
            //Console.Read();

            //new Thread(SayHello).Start("hello-1");
            //new Thread(SayHello).Start("hello-2");
            //new Thread(SayHello).Start("hello-3");

            //Thread.Sleep(2000);
            //handle.Set();
            //Thread.Sleep(2000);
            //handle.Set();
            //Thread.Sleep(2000);
            //handle.Set();
            //Console.Read();


            handle.Set();
            new Thread(SayHello).Start("hello-1");
            new Thread(SayHello).Start("hello-2");
            new Thread(SayHello).Start("hello-3");
            new Thread(SayHello).Start("hello-1");
            new Thread(SayHello).Start("hello-2");
            new Thread(SayHello).Start("hello-3");
            Thread.Sleep(2000);
            handle.Reset();
            new Thread(SayHello).Start("hello-4");
            Thread.Sleep(4000);
            handle.Set();

            #endregion


        }


        public static void run()
        {
            // show this message for the first time
            Console.WriteLine("Application is Currently running");
            Console.ReadLine();
        }

        public static void execute()
        {
            Console.WriteLine("Method-1 Entered");
            Console.ReadLine();
            Console.WriteLine("Method-1 Exited");
        }

        public static void DoSomthing(object id)
        {
            Console.WriteLine(id + "wants to access the semaphore");
            s.WaitOne();
            Console.WriteLine(id + "has succeed to access the semaphore");
            Thread.Sleep(5000);
            Console.WriteLine(id + "is above to leave semaphore");
            s.Release();

        }

        // every time the set event is called method is executed
        // threads are not running simultaneously
        // set method will call one thread at a time
        public static void SayHello(object data)
        {
            Console.WriteLine("inside say hello  " + data);
            handle.WaitOne();  // wait until the event is called 
            Console.WriteLine(data);
        }
    }
}

