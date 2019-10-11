using System;
using System.Collections.Generic;
using System.Text;

namespace _11_10_2019
{
    public class TestGenericMethod
    {
        public void Show<T>(T type)
        {
            Console.WriteLine(type);
        }
    }
    class GenericMethod
    {
        static void Main(string[] args)
        {
            TestGenericMethod tgm = new TestGenericMethod();
            tgm.Show("Hello Brother");
            tgm.Show('O');
            tgm.Show(2546.0012547);

            Console.WriteLine("Success...");

        }
    }
}
