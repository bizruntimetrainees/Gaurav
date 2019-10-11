using System;

namespace _11_10_2019
{
    public class TestGeneric<T>
    {
        public TestGeneric(T type)
        {
            Console.WriteLine(type);
        }
    }

    class GenericClass
    {
        static void Main(string[] args)
        {
            TestGeneric<string> tg = new TestGeneric<string>("This is String type Generic");
            TestGeneric<char> tg1 = new TestGeneric<char>('c');
            TestGeneric<int> tg2 = new TestGeneric<int>(111111);
            Console.WriteLine("Success...");
        }
    }
}
