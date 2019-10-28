using System;
using ProductsApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{Id=1 , Name="Sugar" , Category="groceries" , Price=1},
            new Product{Id=2 , Name="Birayani" , Category="food",  Price =2},
            new Product{Id=3 , Name="computer" , Category="machine" , Price=600 }
        };
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            {
                if(product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
        }

    }
}
