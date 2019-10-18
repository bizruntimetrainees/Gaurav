using System;
using System.Threading.Tasks;


namespace Aynchronous
{
    class Test
    {
        public Task ShowAsync()
        {
            return Task.Run(() =>
            {
                try
                {
                    Task.Delay(2000);
                    throw new Exception("My Own Exception");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });
        }
        public async void Call()
        {
            try
            {
                await ShowAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class AsyncException
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.Call();
            Console.WriteLine("processing....");
        }
    }
}
