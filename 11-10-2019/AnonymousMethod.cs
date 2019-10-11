using System;
using System.Collections.Generic;
using System.Text;

namespace _11_10_2019
{
    public delegate void AnonyMous(int n);
    class AnonymousMethod
    {
        static void Main(string[] args)
        {
            AnonyMous fun = delegate (int n)
            {
                Console.WriteLine("This is anonyMousFunction value:"+n);
            };
            fun(2548);
        }
    }
}
