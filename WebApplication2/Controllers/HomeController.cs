using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        /*public string Get()
        {
            return "Hello World";
            
        }*/

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        //... api/Home
        public string[] Get()
        {
            return new string[] { "apple", "banana", "orange" };
        }
    }
}
