using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day10Delegates
{
    internal class Covarence_demo

    {

        //object is inherited by every type  



        public delegate void Covarence(string s); //derived type 

        public delegate object covarence2(); //base type 

       
        public void display()

        {

            string st = "Hellooo";

            object o = st; //valid 

            Covarence obj = testing;

            covarence2 ob = testing1;

        }



        public string testing1() //derived (covariance) 

        {

            return "";

        }

        public void testing(object st)  // base type (contravariance) 

        {

            //ssf 
            

        }



    }
}
