using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class PeekInQueue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("before removing...");
            Queue<double> queue = new Queue<double>();
            queue.Enqueue(100.21);

            queue.Enqueue(10.24);

            queue.Enqueue(10.320);

            queue.Enqueue(1000.11);

            queue.Enqueue(21.100);

            queue.Enqueue(12.45);

            queue.Enqueue(8.745);

            queue.Enqueue(147.14);

            foreach (double que in queue)
            {
                Console.Write(que + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Peek Element:" + queue.Peek());
            Console.WriteLine("removed Element:" + queue.Dequeue());
            Console.WriteLine("After removing ...");
            foreach (int que in queue)
            {
                Console.Write(que + " ");
            }
            Console.WriteLine();
            Console.WriteLine("After removed peek Element:" + queue.Peek());
            Console.WriteLine("Success...");
        }
    }
}
