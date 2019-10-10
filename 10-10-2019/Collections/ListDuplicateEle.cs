
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _10_10_2019
{
    class ListDuplicateEle
    {
        static void Main(string[] args)
        {
            List<String> names = new List<String>();
            names.Add("Gaurav");
            names.Add("Raghav");
            names.Add("Jyothi");
            names.Add("Ankit");
            names.Add("Mishra");
            names.Add("Mishra");
            names.Add("Jyothi");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("list class can take duplicate elements ...");
        }
    }
}