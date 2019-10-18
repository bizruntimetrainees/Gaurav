using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aynchronous
{
    class Taskcreation
    {
        static void Main(string[] args)
        {
            Task t = new Task(
                () =>
                {
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("A bunch of Task is Finished...");
                });
            t.Start();

            t.Wait();
            Console.WriteLine("Completed...");

        }
    }
}
