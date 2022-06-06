using MVCTutorial1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.Id = 1;
            user.FirstName = "Brady";
            user.LastName = "Pochon";
            user.Age = 35;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid page.");

            return View();
        }

        public ActionResult Contact(int number)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}