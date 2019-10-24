using System;
using System.Collections.Generic;
using System.Text;

namespace JsonProject1
{
    public class Product
    {
            public string name { get; set; }

            public DateTime ExpiryDate { get; set; }

            public float price { get; set; }

            public string[] Sizes { get; set; }
        }
    }

