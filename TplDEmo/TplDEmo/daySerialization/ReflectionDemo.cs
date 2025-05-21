using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TplDEmo.daySerialization
{
    internal class ReflectionDemo
    {
        public void demo1()
        {
            Type t = typeof(string[]);
            Console.WriteLine(t.FullName); // Outputs: System.String
            Console.WriteLine(t.IsValueType);//false
            Console.WriteLine(t.IsAbstract);//false
            Console.WriteLine(t.IsArray);//true
            Console.WriteLine(t.IsSealed); //true

        }

        public void Demo2()
        {// Get the Type object for MyClass
            Type myType = typeof(MyClass);
            Console.WriteLine($"Type Name: {myType.FullName}");
            Console.WriteLine($"Assembly Name: {myType.Assembly.FullName}");
            Console.WriteLine($"Is Class: {myType.IsClass}");
            Console.WriteLine($"Is Public: {myType.IsPublic}");
            Console.WriteLine($"Base Type: {myType.BaseType}");

            // Get Constructors
            Console.WriteLine("\nConstructors:");
            ConstructorInfo[] constructors = myType.GetConstructors();
            foreach (var ctor in constructors)
            {
                Console.WriteLine($"- {ctor}");
            }

            Console.WriteLine("================================");

            MethodInfo[] methods = myType.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine($"- {method}");
            }

            
            Console.WriteLine("================================");

            PropertyInfo[] properties = myType.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine($"- {property}");
            }
        }

        public void demo3()
        {
            //    Console.WriteLine("Enter the dll file");
            //    string data = Console.ReadLine();

            //Assembly asm = Assembly.LoadFrom(data);
            Assembly asm = Assembly.LoadFrom("C:\\Users\\jahnvi.rawat\\Source\\Repos\\TplDEmo\\OtherClass\\bin\\Debug\\OtherClass.dll");

            Type[] t = asm.GetTypes();
            foreach (var item in t)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine(item.Name);
                
                foreach (var i in item.GetMethods())
                {
                    Console.WriteLine(i.Name);
                }
            }
        }
        
        public void demo4()
        {
            Assembly asm = Assembly.LoadFrom("C:\\Users\\jahnvi.rawat\\Source\\Repos\\TplDEmo\\OtherClass\\bin\\Debug\\OtherClass.dll");
            Type t = asm.GetType("OtherClass.Class1");
            dynamic o = Activator.CreateInstance(t);
            o.Add(10,20);
            o.Method1();
            
        }
    }

}
