using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace _11_10_2019
{
    public class TestSynchronized
    { 
        public static void Check(IEnumerable list1)
        {
            Console.WriteLine("Items are below:");
            foreach(Object o in list1)
            {
                
                Console.Write(o);
            }
        }
    }
    class IsSynchronizedProperty
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1254);
            list.Add('h');
            list.Add(true);
            Console.WriteLine("is this list synchronized:" + list.IsSynchronized);
            TestSynchronized.Check(list);

            Console.WriteLine("Success....");
        }

    }
}
