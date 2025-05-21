using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFPattern.StructuralPattern
{
    internal class login
    {
        public void checkUser()
        {
            Console.WriteLine("Login Successfull");
        }
    }

    internal class product
    {
        public void addtoCart()
        {
            Console.WriteLine("item is added to cart");
        }
    }

    internal class makePayment
    {
        public void processPayment()
        {
            Console.WriteLine("payment is processing");
        }
    }

    internal class sendEmail
    {
        public void mailToUser()
        {
            Console.WriteLine("Send email to user");
        }
    }

    class FacedPattern
    {
        login l;
        product p;
        makePayment m;
        sendEmail s;

        public FacedPattern()
        {
            l = new login();
            p = new product();
            m = new makePayment();
            s = new sendEmail();
        }

        public void buyProduct()
        {
            l.checkUser();
            p.addtoCart();
            m.processPayment();
            s.mailToUser();
        }
     }
}
