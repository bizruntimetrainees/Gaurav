using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class RemovinginQueue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("before removing...");
            Queue<Int32> queue = new Queue<Int32>();
            queue.Enqueue(100);

            queue.Enqueue(10);

            queue.Enqueue(100);

            queue.Enqueue(1000);

            queue.Enqueue(2100);

            queue.Enqueue(1245);

            queue.Enqueue(8745);

            queue.Enqueue(147);

            foreach(int que in queue)
            {
                Console.Write(que + " ");
            }
            Console.WriteLine();
            Console.WriteLine("removed Element:"+queue.Dequeue());
            Console.WriteLine("After removing...");
            foreach (int que in queue)
            {
                Console.Write(que + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Success...");
        }
    }
}
