using System;
using System.Collections.Generic;
using System.Text;

namespace _07_10_2019
{
    class ContainsMethod
    {
        static void Main(string[] args)
        {
            string s1 = "Gaurav";
            string s2 = " Mishra";

            Console.WriteLine(s1.Contains("au"));
            Console.WriteLine(s2.Contains("Mi"));
            Console.WriteLine(s1.Contains("ro"));
        }
    }
}
