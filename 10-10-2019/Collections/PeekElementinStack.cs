using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class PeekElementinStack
    {
        static void Main(string[] args)
        {
            Stack<double> stack = new Stack<double>();
            stack.Push(458.7);

            stack.Push(46.57);

            stack.Push(2.187);

            stack.Push(648.7);

            stack.Push(80.00);

            stack.Push(1.00);

            stack.Push(1.00);  // it will store duplicate also

            foreach (double stack1 in stack)
            {
                Console.Write(stack1 + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Peek element is:" + stack.Peek());  

            Console.WriteLine("Success....");
        }
    }
}
