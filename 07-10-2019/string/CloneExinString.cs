using System;
using System.Collections.Generic;
using System.Text;

namespace _07_10_2019
{
    class CloneExinString
    {
        static void Main(string[] args)
        {
            string s1 = "Hey Gaurav";
            string s2 = (String)s1.Clone();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
