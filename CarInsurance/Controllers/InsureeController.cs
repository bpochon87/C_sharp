using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Quote will be compiled based on user entries using method 'GenerateQuote'.
                insuree.Quote = GenerateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        // 'insuree' as a parameter will give us access to that particular insuree.
        public decimal GenerateQuote(Insuree insuree)
        {
            // Our baseline quote cost.
            decimal totalQuote = 50;

            // Getting current age of insuree.
            var today = DateTime.Today;
            var ageOfInsuree = today.Year - insuree.DateOfBirth.Year;

            // 'if else' statements finding costs related to age.
            if (ageOfInsuree <= 18)
            {
                totalQuote += 100;
            }
            else if (ageOfInsuree >= 19 && ageOfInsuree <= 25)
            {
                totalQuote += 50;
            }
            else if (ageOfInsuree > 25)
            {
                totalQuote += 25;
            }

            // 'if else' statements finding costs related to car manufacture date.
            var carYear = insuree.CarYear;
            if (carYear < 2000)
            {
                totalQuote += 25;
            }
            else if (carYear > 2015)
            {
                totalQuote += 25;
            }

            // Pulling in dB information and making sure it's readable.
            var make = insuree.CarMake;
            var carMake = make.ToLower();
            var model = insuree.CarModel;
            var carModel = model.ToLower();
            // 'if else' statements finding costs related to car manufacturer.
            if (carMake == "porsche")
            {
                totalQuote += 25;
                if (carModel == "911 carrera")
                {
                    totalQuote += 25;
                }
            }

            // Multiplying each speeding ticket times ten and assigning it to a decimal.
            decimal speedingTicketCost = insuree.SpeedingTickets * 10;
            totalQuote += speedingTicketCost;

            // If insuree has a DUI, add 25% to total cost.
            var hasDui = insuree.DUI;
            if (hasDui == true)
            {
                totalQuote += totalQuote * (decimal).25;
            }

            // If insuree wants full coverage, add 25% to total cost.
            var fullCoverage = insuree.CoverageType;
            if (fullCoverage == true)
            {
                totalQuote += totalQuote * (decimal).25;
            }

            return totalQuote;
        }
    }
}
