using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day3
{
    internal class studentArray
    {
        public int sID { get; set; }
        public string sName { get; set; }
        public int[] sMarks { get; set; }

        public void displayDetails()
        {
            //string[] res = new string[4];
            Console.WriteLine($" Student Id : {sID}, Student Name: {sName} ");
            for (int i = 0; i < sMarks.Length; i++)
            {
                if (sMarks[i] > 60)
                {
                    //res[i] = "First";
                    Console.WriteLine(sMarks[i] + " : First");
                }
                else if (sMarks[i] > 60 || sMarks[i] < 50)
                {
                    Console.WriteLine(sMarks[i] + " : Second");
                }
                else
                {
                    Console.WriteLine(sMarks[i] + " : Fail");
                }
            }
           
        }
    }
}
