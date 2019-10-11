using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace _11_10_2019
{
    class UsingClone
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("abc");
            list.Add(124);
            list.Add(false);

            for(int i=0;i<=list.Count-1;i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine(list.Clone());
            Console.WriteLine(list.GetHashCode());
        }

    }
}
