using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class sortedwithcollectionInitializer
    {
        static void Main(string[] args)
        {
            var sortedset = new SortedSet<Int32>() { 12, 54, 65, 78, 100, 200, 102 };

            foreach(int sort in sortedset)
            {
                Console.Write(sort + " ");
            }
            Console.WriteLine();
            Console.WriteLine("SortedSet with Collection initializer:");
        }
    }
}
