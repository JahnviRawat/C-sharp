using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.dayFile
{
    internal class dirClass
    {

        public void addDir()
        {
            Console.WriteLine("Enter Directory");
            string str = Console.ReadLine();

            //Console.WriteLine(!Directory.Exists(str));

            if (Directory.Exists(str))
            {

                string[] files = Directory.GetFiles(str);
                Console.WriteLine("Your files:- ");
                foreach (string file in files) { Console.WriteLine(file); }

            }
            else
            {
                Console.WriteLine("Directory Does not Exists ");
                Console.WriteLine("Do you want to create a directory ? ");
                char ans = char.Parse(Console.ReadLine());
                if (ans == 'y')
                {
                    Directory.CreateDirectory(str);

                    FileStream fs = new FileStream(str + "\\hello.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine("Hellooooo");
                    sw.Close();
                    fs.Close();
                    fs.Dispose();

                    FileStream f = new FileStream(str + "\\hello.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    StreamReader sr = new StreamReader(f);
                    Console.WriteLine(sr.ReadToEnd());
                    f.Close();
                    sr.Close();
                    f.Dispose();
                }
                else
                {
                    Console.WriteLine("Thankyou");
                }

            }
        }
    }
}
