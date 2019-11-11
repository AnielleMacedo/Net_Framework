using MyFirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Info()
        {
            Person person = new Person()
            {
                Name = "John",
                Surname = "Doe",
                Age = 25,
                Genre = false,
                Bio = "He's a common man, who lives nearby you"
            };
            
            return View(person);
        }
    }
}