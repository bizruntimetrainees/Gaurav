using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class HashSet
    {
        static void Main(string[] args)
        {
            HashSet<string> hash = new HashSet<string>();
            hash.Add("ROHAN");
            hash.Add("MOHAN");
            hash.Add("BANGALORE");
            hash.Add("CHENNAI");
            hash.Add("MUMBAI");

            foreach(string rehash in hash)
            {
                Console.WriteLine(rehash);
            }
            Console.WriteLine("strings stored successfully in hashset...");
        }
    }
}
