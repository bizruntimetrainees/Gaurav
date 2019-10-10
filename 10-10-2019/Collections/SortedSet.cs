using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class SortedSet
    {
        static void Main(string[] args)
        {
            SortedSet<string> sort = new SortedSet<string>();
                sort.Add("Gaurav");

                sort.Add("Rohit");

                sort.Add("Hemant");

                sort.Add("Ramu");
                
                sort.Add("Raghu");

            foreach(string s in sort)
            {
                Console.Write(s + " ");  // it will take automatic sorting
            }
            Console.WriteLine();
            Console.WriteLine("string stored in sortedset in ascending order..."); 
        }
    }
}
