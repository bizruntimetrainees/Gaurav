using System;
using System.Collections.Generic;
using System.Text;

namespace _14_10_2019
{
    class PublisherClass1
    {
        public delegate void beforeprint(string message);
        public event beforeprint beforePrintEvent;

        public PublisherClass1()
        {

        }
        public void PrintNumber(int num)
        {
            if (beforePrintEvent != null)
            {
                beforePrintEvent.Invoke("PrintNumber");
                Console.WriteLine("Number " + num);
            }
        }
        public void PrintDecimal(int dec)
        {
            if (beforePrintEvent != null)
            {
                beforePrintEvent("PrintDecimal");

                Console.WriteLine("decimal:" + dec);
            }
        }
        public void PrintMoney(int money)
        {
            if (beforePrintEvent != null)
            {
                beforePrintEvent("PrintMoney");
                Console.WriteLine("Money :" + money);
            }
        }
        public void PrintTemprature(int num)
        {
            if (beforePrintEvent != null)
            {
                beforePrintEvent("PrintTemprature");
                Console.WriteLine("Temprature :" + num);
            }
        }
        public void PrintHexaDecimal(int dec)
        {
            if (beforePrintEvent != null)
            {
                beforePrintEvent("PrintHexadecimal");
                Console.WriteLine("HexaDecimal:" + dec);
            }
        }

    }
}
