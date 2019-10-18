using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aynchronous
{
    class ChildTask
    {
        static void Main(String[] args)
        {
            Task parent = new Task(
                () =>
                {
                    Task child = new Task(
                        () =>
                        {
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine("Inner Task completed..");
                        },
                         TaskCreationOptions.AttachedToParent
                        );
                    child.Start();

                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Outer Task Completed...");

                });
            parent.Start();
            parent.Wait();

            Console.WriteLine("Success");
        }
    }
}
