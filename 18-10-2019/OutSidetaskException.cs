using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aynchronous
{
    class Test1
    {
        public  Task ShowAsync()
        {
            throw new Exception("this is my own Exception..");
            return Task.Run(() =>
            {
                Task.Delay(2000);
                
            });
        }
        public async void CallMethod()
        {
            try
            {
                await ShowAsync();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
             
    }
    class OutSidetaskException
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.Call();
            Console.WriteLine("processing....");
        }

    }
}
