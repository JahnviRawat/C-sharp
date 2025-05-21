using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFPattern.creationalPattern
{
    interface IMyDb
    {
        string[] showData();
    }
    internal class SqlData : IMyDb
    {
        public string[] showData()
        {
            string[] data = { "India", "Canada", "UK" };
            return data;
        }
    }

    internal class OracleData : IMyDb
    {
        public string[] showData()
        {
            string[] data = { "CSK", "RCB", "SRH" };
            return data;
        }
    }

    internal class MySQlData : IMyDb
    {
        public string[] showData()
        {
            string[] data = { "Morvi", "Mansi", "Jahnvi" };
            return data;
        }
    }

    class Factory
    {
        // return the instance based upon the input
        public IMyDb GetInstance(int i)
        {
            // if user passes 1 return sql data 
            // if pass 2 return oracle data
            if (i == 1)
            {
                return new SqlData();
            }
            else if(i == 2)
            {
                return new OracleData();
            }
            else
            {
                return new MySQlData();
            }
        }
    }
}
