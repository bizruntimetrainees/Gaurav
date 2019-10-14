using System;
using System.Collections.Generic;
using System.Text;

namespace _14_10_2019
{
    class SuscriberClass1
    {
        private PublisherClass1 _publisherClass1;

        public SuscriberClass1(int val)
        {
            _value = val;

            _publisherClass1 = new PublisherClass1();

            _publisherClass1.beforePrintEvent += publisherClass1_beforePrintEvent;

        }
        void publisherClass1_beforePrintEvent(string message)
        {
            Console.WriteLine("BeforePrintEvent fires from {0}", message);
        }
        private int _value;

        public int value
        {
            get { return _value; }
            set { _value = value; }

        }
        public void PrintMoney()
        {
            _publisherClass1.PrintMoney(_value);
        }
        public void PrintNumber()
        {
            _publisherClass1.PrintNumber(_value);
        }
    }
}

