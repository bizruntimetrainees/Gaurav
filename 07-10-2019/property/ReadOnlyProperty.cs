using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10_2019
{
    class TestProperty1
    {
        private static int count;

        public TestProperty1()
        {
            count++;
        }
        public static int Count
        {
            get
            {
                return count;
            }
        }
    }
    class ReadOnlyProperty
    {
        static void Main(string[] args)
        {
            TestProperty1 t = new TestProperty1();
            TestProperty1 t1 = new TestProperty1();
            TestProperty1 t2 = new TestProperty1();
            Console.WriteLine("number of objects:" + TestProperty1.Count);
        }
        
    }
}
