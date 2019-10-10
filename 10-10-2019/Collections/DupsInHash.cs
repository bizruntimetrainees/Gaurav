using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class DupsInHash
    {
        static void Main(string[] args)
        {
            HashSet<Int32> hash = new HashSet<Int32>();
            hash.Add(500);

            hash.Add(3254);

            hash.Add(0012);

            hash.Add(3548);

            hash.Add(100);

            hash.Add(100); // it will not add this element bcoz it is dups

            
            foreach (int rehash in hash)
            {
                Console.WriteLine(rehash);
            }
            Console.WriteLine("strings stored successfully in hashset...");
        }
    }
}
// hashset does not allow duplicate elements