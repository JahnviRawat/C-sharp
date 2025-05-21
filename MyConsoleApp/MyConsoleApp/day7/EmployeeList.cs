using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.day7
{
    internal class EmployeeList: IEnumerable
    {
        public int id { get; set; }
        public string name { get; set; }
        public string dept { get; set; }

        ArrayList emplist = new ArrayList();
      
        public void AddEmployee(int eid, string ename, string edept)
        {
           emplist.Add(new EmployeeList() { id = eid, name = ename, dept=edept});

        }

        public string this[int index]
        {
            get
            {
                return emplist[index].ToString();
            }
        }

        public void displayEmployee()
        {
            foreach (EmployeeList item in emplist)
            {
                Console.WriteLine(item.id + item.name + item.dept);
                Console.WriteLine("-------------------");
            }
        }

        public IEnumerator GetEnumerator()
        {
            return emplist.GetEnumerator();
        }
    }
}
