using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
    public class Constructor
    {
        public Constructor()
        {
            Console.WriteLine("Base class Constructor:");
        }
    }
    class  DerivedConstructor : Constructor
    {
        public DerivedConstructor()
        {
            Console.WriteLine("derived class Constructor:");
        }
    }
    class BaseClassConstructor
    {
        static void Main(String[] args)
        {
            DerivedConstructor dc = new DerivedConstructor();
            
        }
    }
}
