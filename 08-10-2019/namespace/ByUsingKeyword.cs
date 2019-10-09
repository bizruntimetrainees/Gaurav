using System;
using System.Collections.Generic;
using System.Text;


namespace _07_10_2019
{
    using First;
    using Second;
    namespace First
    {
        public class Hello1
        {
            public void sayHello1()
            {
                Console.WriteLine("this is first namespace:");
            }
        }
    }
    namespace Second
    {
        public class Welcome
        {
            public void sayWelcome()
            {
                Console.WriteLine("this is second namespace:");
            }
        }
    }   
        class ByUsingKeyword
    {
            static void Main(string[] args)
            {
                Hello1 f = new Hello1();
                Welcome W = new Welcome();
                f.sayHello1();
                W.sayWelcome();
                Console.WriteLine("Compile success");
            }
        }
}
