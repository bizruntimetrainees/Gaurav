using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class SortedList
    {
        static void Main(string[] args)
        {
            SortedList<int,String> dict = new SortedList<int,String>();
            dict.Add(3, "Hello");

            dict.Add(5, "587.254");

            dict.Add(1, "Know");

            dict.Add(4, "0.2548");

            dict.Add(2, "Lalli");

            dict.Add(6,"WOW");
            // it will give sorting based on key
            foreach (KeyValuePair<int, String> key in dict)
            {
                Console.WriteLine(key.Key + " " + key.Value);
            }

            Console.WriteLine("Success...");
        }
    }
}
