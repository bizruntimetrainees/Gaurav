using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace _10_10_2019
{
    class HashTableEx
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["One"] = 1;
            ht["Two"] = 2;
            ht["Three"] = 3;
            Console.WriteLine(ht["Two"]);
        }
    }
}
