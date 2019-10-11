using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace _11_10_2019
{
    class ReadOnly
    {
        public  void Read(IEnumerable list1)
        {
            foreach(Object l in list1)
            {
                Console.WriteLine("Elemets are:" + l);
            }
        }
    }
    class IsReadOnlyProperty
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("OM");
            list.Add("Namah");
            list.Add("Shivay");
            Console.WriteLine("is this ArrayList only readable:" + list.IsReadOnly);

            ReadOnly r = new ReadOnly();
            r.Read(list);

        }


    }
}
