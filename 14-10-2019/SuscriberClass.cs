using System;
using System.Collections.Generic;
using System.Text;

namespace _14_10_2019
{
    class SuscriberClass
    {
        private PublisherClass _publisherClass;

        public SuscriberClass(int val)
        {
            _value = val;

            _publisherClass = new PublisherClass();

            _publisherClass.beforePrintEvent += publisherClass_beforePrintEvent;

        }
        void publisherClass_beforePrintEvent()
        {
            Console.WriteLine("beforePrintEventHandler: PublisherClass is going to print a value");
        }
        private int _value;

        public int value
        {
            get { return _value; }
            set { _value = value; }

        }
        public void PrintMoney()
        {
            _publisherClass.PrintMoney(_value);
        }
        public void PrintNumber()
        {
            _publisherClass.PrintNumber(_value);
        }
    }
}
