using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day4
{
    internal abstract class SqlDb
    {
        public string[] names;

        public abstract void connect();  
        //public virtual void connect()
        //{
        //    // logic to read from sql
        //    names = new string[] { "India", "USA", "Aus", "Brazil", "UK","Italy" };
        //}
        public void filter()
        {
            foreach (var name in names)
            {
                if (name.StartsWith("I"))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }

    class OracleDb: SqlDb
    {   
        // override keyword can be used with virtual or abstract
        public override void connect()
        {
            // logic to read from sql
            names = new string[] { "India", "USA", "Aus", "Brazil", "UK", "Italy" ,"Indonesia","Israel"};
        }

    }

    class MySqlDb : SqlDb {
        public override void connect()
        {
            // logic to read from sql
            names = new string[] { "India", "USA", "Aus", "Brazil", "UK", "Italy", "Indonesia", "Israel" ,"Iraq","Iran"};
        }
    }
}
