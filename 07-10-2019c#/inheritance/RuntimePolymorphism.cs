using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
   public  class Runtime
    {
        public string name = "Gaurav";
    }
    class DerivedRuntime : Runtime
    {
        public string name = "Ankit";
    }
    class RuntimePolymorphism
    {
        static void Main(string[] args)
        {
            Runtime r = new DerivedRuntime();
            Console.WriteLine(r.name);
        }
    }
}
