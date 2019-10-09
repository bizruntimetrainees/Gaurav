using System;
using System.Collections.Generic;
using System.Text;

namespace _07_10_2019
{
    class ComparetoMethod
    {
        static void Main()
        {
            string s1 = "Hello";
            string s2 = "Hello";
            string s3 = "Guarav";
            string s4 = "Mishra";
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s3.CompareTo(s4));
            Console.WriteLine(s1.CompareTo(s3));
            Console.WriteLine(s2.CompareTo(s4));
        }
    }
}
