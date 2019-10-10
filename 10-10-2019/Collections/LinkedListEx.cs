using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class LinkedListEx
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of Names");

            LinkedList<string> list = new LinkedList<string>();

            list.AddLast("Mohit");

            list.AddLast("Ramesh");

            list.AddLast("Suresh");

            list.AddLast("Mahesh");

            list.AddLast("Umesh");

            list.AddLast("Sagun");

            list.AddFirst("Zombi");  // it will add in first of the index

            foreach(string rlist in list)
            {
                Console.Write(rlist+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Success..");

        }
    }
}
