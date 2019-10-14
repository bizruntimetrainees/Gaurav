using System;

namespace _14_10_2019
{
    class EventHandler
    {
        static void Main(string[] args)
        {
            SuscriberClass sb = new SuscriberClass(10000);
            sb.PrintMoney();
            sb.PrintNumber();
        }
    }
}
