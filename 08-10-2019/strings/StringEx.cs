using System;
using System.Collections.Generic;
using System.Text;

namespace _07_10_2019
{
    class StringEx
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";

            char[] ch = { 'G', 'a', 'u', 'r', 'a', 'v' };
            string s2 = new string(ch);
            Console.WriteLine("length of the string:" + s2.Length);
            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
