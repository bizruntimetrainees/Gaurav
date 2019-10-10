using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class SortedDictionary
    {
        static void Main(string[] args)
        {
            SortedDictionary<Int32, Int32> sdict = new SortedDictionary<Int32, Int32>();
            sdict.Add(1, 254);

            sdict.Add(2, 587);

            sdict.Add(3,54);

            sdict.Add(4,2548);

            sdict.Add(5,369);

            sdict.Add(6,147);

            foreach (KeyValuePair<Int32, Int32> key in sdict)
            {
                Console.WriteLine(key.Key + " " + key.Value);
            }

            Console.WriteLine("Success...");
        }
    }
}
