using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace JsonProject1
{
    class DictionarySerialize
    {
        public static void GetDetails()
        {



            Dictionary<int, string> d = new Dictionary<int, string>
            {
                { 1,"Gaurav"},
                {2,"Mishra" },
                {4,"Raghav" },
                {7,"Mosam" }

            };
            string serialize = JsonConvert.SerializeObject(d, Formatting.Indented);
            Console.WriteLine(serialize);

        }
        static void Main(string[] args)
        {
            DictionarySerialize.GetDetails();
            Console.WriteLine("Success...");
        }
    }
}
