using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using TplDEmo.daySerialization;

namespace TplDEmo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region // task
            //Stopwatch sw = new Stopwatch();
            //sw.Start();

            //Stopwatch sw = Stopwatch.StartNew();    
            //parallelDemo parallelDemo = new parallelDemo();
            ////parallelDemo.NonParallelMethod();
            //parallelDemo.ParallelMethod();

            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);
            //parallelDemo.demo10();
            #endregion

            #region // Serialization, Deserialization
            //serializationDemo serializationDemo = new serializationDemo();
            //serializationDemo.Serialization();
            //Console.Read();

            //Customers ob = new Customers()
            //{
            //    id = 1,
            //    name = "Morvi",
            //    age = 23,
            //    address = "Bangalore"
            //};

            //ob.serMethod();
            //ob.deserMethod();

            //serDemoBinary sb = new serDemoBinary();
            ////sb.serDemobin();
            ////sb.deserDemobin();
            //sb.jsonSerDemo();
            //sb.jsonDeserDemo();


            //Originator originator = new Originator();
            //Caretaker caretaker = new Caretaker();

            //originator.State = "Initial State";
            //Console.WriteLine("State set to: " + originator.State);

            //Memento savedState = originator.SaveState();
            //caretaker.SaveToXml(savedState, "memento.xml");

            //originator.State = "Modified State";
            //Console.WriteLine("State changed to: " + originator.State);

            //// Restore from XML
            //Memento restoredState = caretaker.LoadFromXml("memento.xml");
            //originator.RestoreState(restoredState);
            //Console.WriteLine("State restored to: " + originator.State);

            #endregion

            #region // reflection

            ReflectionDemo rd = new ReflectionDemo();
            //rd.demo1();
            //rd.Demo2();
            rd.demo3();
            //rd.demo4();

            #endregion
        }
    }
}
