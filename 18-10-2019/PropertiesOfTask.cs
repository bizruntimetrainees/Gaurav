using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aynchronous
{
    class PropertiesOfTask
    {
        static void Main(String[] args)
        {
            Task t = new Task(
                () =>
                {
                    System.Threading.Thread.Sleep(2000);
                });
            t.Start();
            t.Wait();

            Console.WriteLine("task status:" + t.Status);
            Console.WriteLine("task cancelation :" + t.IsCanceled);
            Console.WriteLine("task completion :" + t.IsCompleted);
            Console.WriteLine("Task fault :" + t.IsFaulted);

            Console.WriteLine("End Of Main");

        }
    }
}
