using System;
using System.Collections.Generic;
using System.Text;

namespace _07_10_2019
{
    class GetDataFromEncapsulationEx
    {
        static void Main(string[] args)
        {
            EncapsulationEx en = new EncapsulationEx();
            // setting Data
            en.id = 12145;
            en.name = "Gaurav Mishra";
            en.address = "Bavgalore";
            // geting Data

            Console.WriteLine("Id is:" + en.id);
            Console.WriteLine("name is:" + en.name);
            Console.WriteLine("Address is:" + en.address);

        }
    }
}
