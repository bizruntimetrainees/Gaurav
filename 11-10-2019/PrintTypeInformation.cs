using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _11_10_2019
{
    class PrintTypeInformation
    {
        static void Main(string[] args)
        {
            Type type = typeof(System.String);
            Console.WriteLine(type.FullName);
            Console.WriteLine(type.BaseType);
            Console.WriteLine(type.IsClass);
            Console.WriteLine(type.IsEnum);
            Console.WriteLine(type.IsInterface);

            Console.WriteLine("Success...");
        }
    }
}
