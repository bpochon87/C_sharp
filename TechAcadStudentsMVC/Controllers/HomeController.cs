using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models; // This must be added to use properties from our Instructor class.

namespace TechAcadStudentsMVC.Controllers
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
            ViewBag.Message = "Contact Page - The Tech Academy";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Instructor instructor = new Instructor
            {
                Id = 1,
                FirstName = "Brady",
                LastName = "Pochon"
            };

            return View(instructor);
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Osvaldo",
                    LastName = "Marquez"
                },

                new Instructor
                {
                    Id = 2,
                    FirstName = "Brady",
                    LastName = "Pochon"
                },

                new Instructor
                {
                    Id = 3,
                    FirstName = "Sara",
                    LastName = "Pochon"
                }
            };
            return View(instructors);
        }
    }
}