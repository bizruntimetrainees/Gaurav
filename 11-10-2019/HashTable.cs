using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _11_10_2019
{
    class Test
    {
        public static void Hash(IEnumerable table1)
        {
            foreach (DictionaryEntry entry in  table1)
            {
                Console.WriteLine(entry.Key+" "+ entry.Value); 
            }
        }
    }
    class HashTable
    {
        static void Main(string[] args)

        {
            Hashtable table = new Hashtable();
            table.Add(1, "Hello");
            table.Add(2, "Gaurav");
            table.Add(3, "Mishra");
            table.Add(4, "humma");
            Console.WriteLine("key value pair is given below;");
            Test.Hash(table);

        }
    }
}
