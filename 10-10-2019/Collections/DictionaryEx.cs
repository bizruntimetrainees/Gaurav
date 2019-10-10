using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class DictionaryEx
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("1", "Gaurav");

            dict.Add("2", "Saurav");

            dict.Add("3", "Mohit");

            dict.Add("4", "Amma");

            dict.Add("5", "Appa");

            dict.Add("6", "Jaggu");

            foreach(KeyValuePair<string,string> key in dict)
            {
                Console.WriteLine(key.Key+ " "+key.Value);
            }
            
            Console.WriteLine("Success...");
        }
    }
}
