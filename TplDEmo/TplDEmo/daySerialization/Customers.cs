using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TplDEmo.daySerialization
{
    public class Customers
    {
        [XmlAttribute]
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        [XmlIgnore]
        public string address { get; set; }


       public void serMethod()
        {
            FileStream fs = new FileStream("C:\\webD\\customerSer.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // type of data you want to serialize
            XmlSerializer xr = new XmlSerializer(typeof(Customers));
            xr.Serialize(fs, this);

            fs.Close();
            fs.Dispose();
        }

        public void deserMethod()
        {
            
            FileStream fs = new FileStream("C:\\webD\\customerSer.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // type of data you want to serialize
            XmlSerializer xr = new XmlSerializer(typeof(Customers));
            Customers ob = (Customers)xr.Deserialize(fs);

            Console.WriteLine("Id: " + ob.id);
            Console.WriteLine("name: " + ob.name);
            Console.WriteLine("age: " + ob.age);

            fs.Close();
            fs.Dispose();

        }

  

    }
}
