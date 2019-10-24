using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JsonProject1
{
   public class ProductDetails
    {

        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("fatching Details... ");
                SerializedDeserialized sd = new SerializedDeserialized();
                sd.GetDetails();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.." + e.ToString());
            }
            finally
            {
                Console.WriteLine("finally block executed....");
            }

        }
    }
}

