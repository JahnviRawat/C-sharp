using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day5
{
    internal class tuples
    {
        public Tuple<string,string> splitFullName(string input)
        {
            string[] str = input.Split(' ');
            Tuple<string,string> str1 = new Tuple<string,string>(str[0],str[1]);
            return str1;
        }
    }
}
