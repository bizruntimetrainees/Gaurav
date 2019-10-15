using System;
using System.Collections.Generic;
using System.Text;

namespace _15_10_2019
{
    class PredicateDelegate
    {
        public static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
        public static void Main()
        {
            Predicate<string> isUpper = IsUpperCase;

            bool result = isUpper("hello world!!");

            Console.WriteLine(result);
        }

    }
}
