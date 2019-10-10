using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class RemoveinHash
    {
        static void Main(string[] args)
        {
            HashSet<char> hash = new HashSet<char>();
            hash.Add('A');

            hash.Add('B');

            hash.Add('C');

            hash.Add('D');

            hash.Add('E');

            hash.Add('F'); 


            foreach (char rehash in hash)
            {
                Console.WriteLine(rehash);
            }
            hash.Remove('C');
            Console.WriteLine("after removing...");
            foreach(char h in hash )
            {
                Console.WriteLine(h);
            }
            Console.WriteLine("Integer stored successfully in hashset...");
        }
    }
}
