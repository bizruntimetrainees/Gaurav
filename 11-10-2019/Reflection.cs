using System;
using System.Collections.Generic;
using System.Text;

namespace _11_10_2019
{
    class Reflection
    {
        static void Main(string[] args)
        {
            int a = 10;
            Type type = a.GetType();
            Console.WriteLine(type);
        }
    }
}
