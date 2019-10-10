using System;
using System.Collections.Generic;
using System.Text;

namespace _10_10_2019
{
    class QueueEx
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Staes:");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Madhyapradesh");

            queue.Enqueue("Uttarpradesh");

            queue.Enqueue("Himachalapradesh");

            queue.Enqueue("Andhrapradeshpradesh");

            queue.Enqueue("Uttarakhand");

            queue.Enqueue("Maharashtra");

            queue.Enqueue("Karnataka");

            queue.Enqueue("Keral");

            foreach(string que in queue)
            {
                Console.Write(que+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Elements stored in Queue Successfully...");

        }
    }
}
