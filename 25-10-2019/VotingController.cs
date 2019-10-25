using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class VotingController : Controller
    {
        
        public string Index()
        {
            int age = 18;

            if(age>=18)
            {
               return HttpUtility.HtmlEncode("Eligible to vote:");
            }
            else
            {
                return HttpUtility.HtmlEncode("Not Eligible to vote:");
            }
        }
        
    }
}