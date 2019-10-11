using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace _11_10_2019
{
    class Reverse
    {
        public static void GetItems(IEnumerable list1)
        {
            foreach(Object O in list1)
            {
                Console.WriteLine(O);
            }
            
        }
    }
    class ReverseinArrayList
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(125.5);
            list.Add(false);
            list.Add("Hello");
            list.Add(5487);
            Console.WriteLine("Items are below:");
            Reverse.GetItems(list);

            Console.WriteLine("After Reversing..");
            list.Reverse();
            Reverse.GetItems(list);
            Console.WriteLine("Success...");
        }
    }
}
