using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aynchronous
{
    class StatusOfTask
    {
        static void Main(string[] args)
        {
            Task t = new Task(
                ()=>
                {
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Task status seen..");
            });
            t.Start();
            t.Wait();

            Console.WriteLine(t.Status);

        }
    }
}
