using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aynchronous
{
    class HandleExceptionfromAsyncMethod
    {
        public static async Task AsyncFun()
        {
            try
            {
                throw new Exception("I Generated Exception..");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
            public static async void Call()
            {
                await AsyncFun();
            Console.WriteLine("Exception Handled..");
            }
        static void Main(string[] args)
        {
            Call();

            Console.WriteLine("End of Main..");
        }

        }
        
    }

