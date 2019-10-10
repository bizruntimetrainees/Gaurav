using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class CollectionInitializerinHash
    {
        static void Main(string[] args)
        {
            var hash = new HashSet<double>() { 2.1, 5.4, 524.01, 587.254, 8754.300 };
             // using Collection initializer

            foreach(double h in hash)
            {
                Console.WriteLine(h);
            }
            Console.WriteLine("value stored successfully");
        }
    }
}
