using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class StackEx
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("goru");

            stack.Push("Bholu");

            stack.Push("Hare");

            stack.Push("Chandu");

            stack.Push("Lampu");

            stack.Push("Happu");

            stack.Push("Jhabbu");

            //  stack does not take unique elements
            
            foreach(string st in stack)
            {
                Console.WriteLine(st + " ");
            }
            Console.WriteLine("Success..");
        }
    }
}
