using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace JsonProject1
{
   public  class SerializedDeserialized
    {
        public  void GetDetails()
        {
            
            try
            {
                Product product = new Product();

                product.name = "D-Cold syrup";
                product.ExpiryDate = new DateTime(2021, 10, 25);
                product.price = 69.35f;
                product.Sizes = new string[] { "Small", "Medium", "Large" };

                string output = JsonConvert.SerializeObject(product);

                Product deserilized = JsonConvert.DeserializeObject<Product>(output);
                Console.WriteLine("Product Name :" + deserilized.name);
                Console.WriteLine("Product ExpiryDate :" + deserilized.ExpiryDate);
                Console.WriteLine("Product Price :" + deserilized.price);
                Console.Write("Product sizes :[");
                foreach (string s in product.Sizes)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine("]");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

        }
    }
}
