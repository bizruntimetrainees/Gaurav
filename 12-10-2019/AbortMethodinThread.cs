using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace _12_10_2019
{
    public  class UsingAbort
    {
        public static void Thread1()
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(300);
            }
        }
    }
 
    class AbortMethodinThread
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Main");
            Thread thread = new Thread(new ThreadStart(UsingAbort.Thread1));
            
            thread.Start();
            

            try
            {
                thread.Abort();
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("finally block is executed...");
            }
            Console.WriteLine("End of the Main..");

        }
    }
}
