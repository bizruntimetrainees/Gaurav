using System;
using System.Collections.Generic;
using System.Text;

namespace _14_10_2019
{
   public class PublisherClass
    {
        public delegate void beforeprint();
        public event beforeprint beforePrintEvent;

        public PublisherClass()
        {

        }
        public void PrintNumber(int num)
        {
            if(beforePrintEvent != null)
            {
                beforePrintEvent();
                Console.WriteLine("Number "+ num);
            }
        }
        public void PrintDecimal(int dec)
        {
            if(beforePrintEvent != null)
            {
                beforePrintEvent();

                Console.WriteLine("decimal:"+ dec);
            }
        }
        public void PrintMoney(int money)
        {
            if(beforePrintEvent != null)
            {
                beforePrintEvent();
                Console.WriteLine("Money :"+ money);
            }
        }
        public void PrintTemprature(int num)
        {
            if(beforePrintEvent != null)
            {
                beforePrintEvent();
                Console.WriteLine("Temprature :"+ num);
            }
        }
        public void PrintHexaDecimal(int dec)
        {
            if(beforePrintEvent != null)
            {
                beforePrintEvent();
                Console.WriteLine("HexaDecimal:"+ dec);
            }
        }

    }
}
