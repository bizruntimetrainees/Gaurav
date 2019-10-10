using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class FindMethodinLinkedlist
    {
        static void Main(string[] args)
        {

            LinkedList<string> list = new LinkedList<string>();

            list.AddLast("Mohit");

            list.AddLast("Ramesh");

            list.AddLast("Suresh");

            list.AddLast("Mahesh");

            list.AddLast("Umesh");

            list.AddLast("Sagun");

            list.AddFirst("Zombi");
            Console.WriteLine("Before Adding elements");
            foreach (string rlist in list)
            {
                Console.Write(rlist + " ");
            }
            Console.WriteLine();
            Console.WriteLine("After adding elements..");

            LinkedListNode<string> node = list.Find("Mahesh");
            list.AddBefore(node,"Bholu"); // it will add before Mahesh
            list.AddAfter(node, "Amit");  // it will add after Mahesh

            foreach (string rlist in list)
            {
                Console.Write(rlist + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Success..");

        }
    }
}
