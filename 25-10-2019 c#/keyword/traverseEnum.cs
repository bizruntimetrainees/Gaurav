using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class traverseEnum
    {
        public enum Days { sun, mon, tue, wed, thur, fri, sat };

        static void Main(string[] args)
        {
            foreach (string s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(s);
            }
        }
    }
}
