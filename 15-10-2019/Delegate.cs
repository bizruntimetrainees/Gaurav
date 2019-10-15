using System;

namespace _15_10_2019
{
    public delegate int Call(int i);
    public class Delegate
    {
        static int num = 100;
        public static int  Addition(int i)
        {
            num = num + i;
            return num;
        }
        public static int Devision(int i)
        {
            num = num/i;
            return num;
        }
        public static int GetNumber()
        {
            
            return num;
        }

        static void Main(string[] args)
        {
            Call c = new Call(Addition);
            Call c1 = new Call(Devision);
            c(20);
            Console.WriteLine("After addition num is:"+Delegate.GetNumber());
            c(30);
            Console.WriteLine("After divesion num is:" + Delegate.GetNumber());
        }
    }
}
