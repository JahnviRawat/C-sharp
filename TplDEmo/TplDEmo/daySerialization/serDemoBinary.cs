using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.Collections;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace TplDEmo.daySerialization
{
    internal class serDemoBinary
    {
        public void serDemobin()
        {
            ArrayList li = new ArrayList();
            li.Add("Morvi");
            li.Add("Mansi");
            li.Add("Prince");
            li.Add("Mridul");
            li.Add("Rathan");
            li.Add("Shailesh");
            li.Add("Apoorv");

            FileStream fs = new FileStream("C:\\webD\\studentsSerbin.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // type of data you want to serialize
           BinaryFormatter bf = new BinaryFormatter();
           bf.Serialize(fs, li);

            fs.Close();
            fs.Dispose();
            Console.WriteLine("File Created Successfully");
        }

        public void deserDemobin()
        {
            ArrayList li = new ArrayList();

            FileStream fs = new FileStream("C:\\webD\\studentsSerbin.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // type of data you want to serialize
            BinaryFormatter bf = new BinaryFormatter();
            li = (ArrayList)bf.Deserialize(fs);

            fs.Close();
            fs.Dispose();

            foreach (var item in li) {
                Console.WriteLine(item);
            }
        }

        public void jsonSerDemo()
        {
            Customers[] customers = {
                new Customers()
                {
                    id = 1,
                    name = "Jahnvi",
                    age = 30,
                    address = "Bangalore"
                },
                new Customers()
                {
                    id = 2,
                    name = "Morvi",
                    age = 30,
                    address = "Bangalore"
                }
            };

            string data = JsonSerializer.Serialize(customers);
            File.WriteAllText("C:\\webD\\customer.json", data);
            Console.WriteLine("File Created");
        }

        public void jsonDeserDemo()
        {
            
            Customers customers = new Customers();
            string data = File.ReadAllText("C:\\webD\\customer.bin");

            Customers obj = JsonSerializer.Deserialize<Customers>(data);
            Console.WriteLine(obj.id);
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.age);
            Console.WriteLine(obj.address);

        }
    }
}
