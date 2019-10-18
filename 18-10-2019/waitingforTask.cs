using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aynchronous
{
    class waitingforTask
    {
        static void Main(string[] args)
        {
            Task t = new Task(() =>
               {
                   System.Threading.Thread.Sleep(5000);
                   Console.WriteLine("task Completed..");
               });
            t.Start();

            bool bwait = t.Wait(1000);

            Console.WriteLine("small task will be finish first...");
        }

    }
}
