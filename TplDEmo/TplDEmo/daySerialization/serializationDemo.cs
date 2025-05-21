using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace TplDEmo.daySerialization
{
    internal class serializationDemo
    {
        public void Serialization()
        {
            // object is converted to file
            ArrayList li = new ArrayList();
            li.Add("Morvi");
            li.Add("Mansi");
            li.Add("Prince");
            li.Add("Mridul");
            li.Add("Rathan");
            li.Add("Shailesh");
            li.Add("Apoorv");

            FileStream fs = new FileStream("C:\\webD\\studentSer.xml",FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // type of data you want to serialize
            XmlSerializer xr = new XmlSerializer(typeof(ArrayList));
            xr.Serialize(fs, li);

            fs.Close();
            fs.Dispose();
            Console.WriteLine("File Created Successfully");
        }

        public void Deserialization()
        {
            // file is converted to Object

            ArrayList li = new ArrayList();
            FileStream fs = new FileStream("C:\\webD\\studentSer.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xr = new XmlSerializer(typeof(ArrayList));

            li = (ArrayList)xr.Deserialize(fs);

            foreach (ArrayList item in li) {
                Console.WriteLine(item);
            }
            fs.Close();
            fs.Dispose();

            Console.WriteLine("Total name presesnt is" + li);
        }
    }
}
