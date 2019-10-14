using System;
using System.Collections.Generic;
using System.Text;

namespace _14_10_2019
{
    class EventArguments
    {
        static void Main(string[] args)
        {
            SuscriberClass1 sb = new SuscriberClass1(10000);
            sb.PrintMoney();
            sb.PrintNumber();
        }
    }
}
