using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day3
{
    internal class Student
    {
        public int sId { get; set; }
        public string sName { get; set; }
        public int sMarks { get; set; }

        public void getGrade()
        {
            int per = sMarks / 8;
            string res;

            if (per < 50)
            {
                res = "fail";
            }
            else if (per > 50 || per < 60)
            {
                res = "Second";
            }
            else
            {
                res = "first";
            }

            Console.WriteLine($"student Id: {sId}, student Name = {sName}, Result: {res} ");
        }
    }
}
