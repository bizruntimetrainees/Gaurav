using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class SortedSetwithUnique
    {
        static void Main(string[] args)
        {
            SortedSet<string> sort = new SortedSet<string>();
            sort.Add("Gaurav");

            sort.Add("Rohit");

            sort.Add("Hemant");

            sort.Add("Ramu");

            sort.Add("Raghu");

            sort.Add("Raghu"); // it will no be print

            sort.Add("Ramu"); // this one also not be print bcoz it takes unique element


            foreach (string s in sort)
            {
                Console.Write(s + " ");  
            }
            Console.WriteLine();
            Console.WriteLine("string stored in sortedset with unique element...");
        }
    }
}
