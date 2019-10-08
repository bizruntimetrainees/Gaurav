using System;

namespace _07_10_2019
{
    namespace First
    {
      public class Hello
        {
            public void sayHello()
            {
                Console.WriteLine("this is first namespace:");
            }
        }
    }
    namespace Second
    {
       public class Hello
        {
            public void sayHello()
            {
                Console.WriteLine("this is second namespace:");
            }
        }
    }
    public class NamespaceEx
    {
        static void Main(string[] args)
        {
            First.Hello f1 = new First.Hello();
            Second.Hello f2 = new Second.Hello();
            f1.sayHello();
            f2.sayHello();
            Console.WriteLine("Compile success");
        }
    }
}
