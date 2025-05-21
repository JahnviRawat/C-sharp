using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day10Delegates
{
    internal class delRealtime
    {
        public  delegate bool myRealDel(int x);
        public void filterData(int[] data, myRealDel d)
        {
            foreach (int i in data) {
                if (d.Invoke(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
