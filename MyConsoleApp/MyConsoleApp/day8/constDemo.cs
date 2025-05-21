using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day8
{
    internal class constDemo
    {

        // Once assigned value cannot be changed
        // const  => are called by class name
        // readonly => are called by class name 

        // -----------> declare const variable

        // assign the value during declaration itself
        //not possible 
        //public const string data;

        //value cannot be changed later
        //public const string data = "hello";
        //data = "hello world";

        //database url it will be global variable evry function can use it

        // this is not allowed 
        // string st = "hello";
        //public const string data = st;

        // this is allowed if both the variables are const
        const string st = "hello";
        public const string data = st;

        //null can be assigned to const
        //public const string data2 = null;

        // const cannot be unassigned

        // not possible -> in const you need to assign the value at declaration itself
        //public const int MyProperty { get; set; }

        //======================================================================================
        // -----------> readonly
        // value can be changed via constrictor only 

        public readonly string data2 = "hello";

        //possible
        //public readonly string data3;

        public  constDemo()
        {
            data2= "hello world";
        }


    }
}
