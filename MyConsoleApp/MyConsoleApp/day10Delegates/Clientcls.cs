using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day10Delegates
{
    internal class Clientcls
    {
        // recieve the message
        // subscribe to it (+=)

        Servercls ob = new Servercls();
        public Clientcls() {
            ob.myEvt += Ob_myEvt;
        }

        // this functioned is called by server not by client
        private void Ob_myEvt(string msg)
        {
            // recieve the message from server

            Console.WriteLine(msg);

        }
        public void execute()
        {
            ob.sendMessage();
        }
    }
}
