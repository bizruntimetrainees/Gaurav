using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace JsonProject1
{
    class SerializeCollection
    {
        public static void GetDetails()
        {
            List<string> list = new List<string>
            {
                "Gaurav",
                "Mishra",
                "Bhopal",
                "Bangalore"
            };

            string serialize = JsonConvert.SerializeObject(list);

            Console.WriteLine("after serialized :" + list);
        }
        static void Main(string[] args)
        {
            SerializeCollection.GetDetails();
            Console.WriteLine("Success..");
        }
    }
}
