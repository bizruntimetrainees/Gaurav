using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class RemovinginStack
    {
        static void Main(string[] args)
        {
            Stack<Int32> stack = new Stack<Int32>();
            stack.Push(4587);

            stack.Push(4657);

            stack.Push(2187);

            stack.Push(6487);

            stack.Push(80);

            stack.Push(100);

            foreach(int stack1 in stack)
            {
                Console.Write(stack1 + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Pop element is:"+stack.Pop());  // it will follow LIFO (100 will remove)

            Console.WriteLine("After Pop..");

            foreach (int stack1 in stack)
            {
                Console.Write(stack1 + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Success....");
        }
    }
}
