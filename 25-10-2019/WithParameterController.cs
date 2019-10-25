using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class WithParameterController : Controller
    {
        
        public int Index()
        {
            return 1;
        }
        public int factorial(int num=5)
        {
           int fact = 1;

            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            return (fact);
        }
    }
}