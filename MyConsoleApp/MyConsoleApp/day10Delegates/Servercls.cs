using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day10Delegates
{
    internal class Servercls
    {
        // create events
        //creare delegate
        // raise events
        //sender code

        public delegate void senderDel(string msg);
        public event senderDel myEvt;

        public void sendMessage()
        {
            // this code will call the function in client class ob_myEvt
            myEvt("Hello from server");
        }
    }
}
