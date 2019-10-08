using System;
using System.Collections.Generic;
using System.Text;

namespace _07_10_2019
{
    class CompareOrdinalMethod
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "Hello";
            string s3 = "Guarav";
            string s4 = "Mishra";
            Console.WriteLine(string.CompareOrdinal(s1, s2));
            Console.WriteLine(string.CompareOrdinal(s3, s4));
            Console.WriteLine(string.CompareOrdinal(s1, s3));
            Console.WriteLine(string.CompareOrdinal(s2, s4));
        }
    }
}
