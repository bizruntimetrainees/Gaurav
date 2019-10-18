using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Aynchronous
{

    class SyncandAsyncTogether
    {
        public static async Task<string> AsyncFun()
        {
            return "Hello Gud Morning";
        }
        public static async void CallAsync()
        {
            await AsyncFun();

        }
        public static string NonAsync()
        {
            return "this is nonAsynch";
        }
        public static void CallNonAsync()
        {
            NonAsync();
        }
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            CallAsync();
            Console.WriteLine("Asynchronous Call:" + sw.ElapsedTicks);
            sw.Reset();
            sw.Start();
            CallNonAsync();
            Console.WriteLine("Synchronous Call:" + sw.ElapsedTicks);
            sw.Stop();


        }

    }
}
