using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyConsoleApp.dayFile
{
    internal class FileDemo
    {
        // filestream, stream reader, stream writer
        //FileStream FileStream = new FileStream(@"C:\webD\myFileDir\hello.txt",Create);  
        // create -> override if file exists, createnew -> throws error if file already exists
        // open -> opens an existing file, openorcreate -> opens if exits, if does not exist it will create a file
        //truncate -> opens existing file and erases all data
        // append  -> appends the data 
        public void demo1()
        {
            FileStream fs = new FileStream("C:\\webD\\myFileDir\\hello.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hi this is my new file");
            sw.WriteLine("----------------------");
            sw.WriteLine("let's have some funnnnnnn");
            
            //StreamReader sr = new StreamReader(fs);
            
            //Console.WriteLine("Congrats, File created !!!");
            //Console.WriteLine("File content: " + sr.ReadToEnd());

            sw.Close();
            //sr.Close();
            fs.Close();
            fs.Dispose();
        }
        public void demo2() {
            FileStream fs = new FileStream("C:\\webD\\myFileDir\\hello.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            Console.WriteLine("Congrats, File created !!!");
            var res = sr.ReadToEnd();
            Console.WriteLine("File content: " + res);

            sr.Close();
            fs.Close();
            fs.Dispose();
        }
        public void demo3()
        {
            FileInfo fi = new FileInfo("C:\\webD\\myFileDir\\hello.txt");
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.Directory);
            Console.WriteLine(fi.DirectoryName);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.IsReadOnly);
            Console.WriteLine(fi.LastAccessTime);
        }

        public void demo4()
        {
            FileStream fs = new FileStream("C:\\webD\\myFileDir\\hello.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write("Hllo");
            bw.Write(4.5);
            bw.Write(true);
            bw.Write("Helloo");
            bw.Close();
            fs.Close();
            fs.Dispose();

            FileStream f = new FileStream("C:\\webD\\myFileDir\\hello.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(f);
            Console.WriteLine(br.ReadString());
            //Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadBoolean());
            Console.WriteLine(br.ReadDouble());

            br.Close();
            f.Close();
            f.Dispose();

        }

        public void demo5()
        {
            FileStream fs = new FileStream("C:\\webD\\myFileDir\\studentdata.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fs);

            StudentDet[] studentDet = new StudentDet[3]
            {
                new StudentDet(){studentId=1,studentName="Morvi",height=5.5},
                new StudentDet(){studentId=2,studentName="Mansi",height=5.2},
                new StudentDet(){studentId=3,studentName="Manu",height=5.11}
            };

            foreach (var item in studentDet)
            {
                bw.Write(item.studentId);
                bw.Write(item.studentName);
                bw.Write(item.height);
            }

            bw.Close();
            fs.Close();
            fs.Dispose();
            Console.WriteLine("File Created Successfully");
        }

        public void demo6()
        {
            StudentDet studentDet = new StudentDet();
            FileStream fs = new FileStream("C:\\webD\\myFileDir\\studentdata.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                studentDet.studentId = br.ReadInt32();
                studentDet.studentName = br.ReadString();
                studentDet.height = br.ReadDouble();

                Console.WriteLine($"Student id: {studentDet.studentId}, Student Name: {studentDet.studentName}, Student Height: {studentDet.height} ");
            }
        }

        public void ReadData(TextReader tr)
        {
            string str;
            while ((str = tr.ReadLine()) != null)
            {
                //str = tr.ReadLine();
                Console.WriteLine(str);
            }
        }

        public void demo7()
        {
            string str = "this is data \n for temporary \n storage";
            // converts string to byte array
            byte[] b = System.Text.Encoding.UTF8.GetBytes(str);
            MemoryStream ms = new MemoryStream(b);
            StreamReader sr = new StreamReader(ms);
            //string line = sr.ReadToEnd();
            string line = sr.ReadLine();

            Console.WriteLine(line);
            
            sr.Close();
            ms.Close();

        }

        public void demo8()
        {
            Directory.CreateDirectory("C:\\webD\\myFileDir\\newDir");

            Console.WriteLine(Directory.Exists("C:\\webD\\myFileDir\\newDir"));
        }

        public void demo9() {
            string p = "C:\\webD\\mansiDir\\hello.txt";
            string str = Path.GetDirectoryName(p);
            Console.WriteLine("Get Directory Name : "+ str);
            Console.WriteLine("Get Extension : " + Path.GetExtension(p));
            Console.WriteLine("Get FileName : " + Path.GetFileName(p));
            Console.WriteLine("Get FileName Without Extension : " + Path.GetFileNameWithoutExtension(p));
            Console.WriteLine("Get FullPath : " + Path.GetFullPath(p));
            Console.WriteLine("Get PathRoot : " + Path.GetPathRoot(p)); 
        }
    }

    class StudentDet
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public double height { get; set; }
    }
}
