using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOFPattern.BehavioralPattern;
using GOFPattern.creationalPattern;
using GOFPattern.StructuralPattern;

namespace GOFPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // how to call singleton class 
            //var ob = SingletonPattern.GetInstance;
            //ob.Method();

            //-----------------------------------------------------------------
            //Factory ob = new Factory();
            //var ob1 = ob.GetInstance(1);
            //var data = ob1.showData();
            //foreach (var item in data) { 
            //    Console.WriteLine(item);
            //}

            //-----------------------------------------------------------------
            //Circle ob = new Circle();
            //ob.Radius = 10;
            //ob.Color = "red";
            //ob.Draw();

            //Circle ob1 = new Circle();
            //ob1 = (Circle)ob.Clone();
            //ob1.Draw();
            //ob1.Color = "blue";
            //ob1.Draw();
            //ob.Draw();  

            //-----------------------------------------------------------------
            //IPrinter ob = new ModernPrinter();
            //ob.Print("Hello World");

            //LegacyPrinter lpob = new LegacyPrinter();
            //ob = new LegacyPrinterAdapter(lpob);
            //ob.Print("Hello....");

            //-----------------------------------------------------------------
            //First time
            //login l = new login();
            //l.checkUser();

            //product p = new product();
            //p.addtoCart();

            //makePayment makePayment = new makePayment();
            //makePayment.processPayment();

            //sendEmail sendEmail = new sendEmail();
            //sendEmail.mailToUser();

            //FacedPattern ob = new FacedPattern();
            //ob.buyProduct();
            //books books = new onlineDelivery();
            //books.ProcessData();
            ////-------------------
            //books = new physicalDelivery();
            //books.ProcessData();
            //-----------------------------------------------------------------

            NotificationService notificationService = new NotificationService();

            User user1 = new User("Alice");
            User user2 = new User("Bob");
            User user3 = new User("Mansi");
            User user4 = new User("Morvi");
            

            notificationService.Subscribe(user1);
            notificationService.Subscribe(user2);
            notificationService.Subscribe(user3);
            notificationService.Subscribe(user4);

            notificationService.NotifyObservers("Hello");
            Console.WriteLine();
            notificationService.Unsubscribe(user1);
            notificationService.NotifyObservers("Hello");
        }
    }
}
