using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GarageLux.DataAccessLayer;
using GarageLux.Models;

namespace GarageLux.Controllers
{
    public class IncheckedVehiclesController : Controller
    {
        private IncheckedVehicleContext db = new IncheckedVehicleContext();

        // GET: IncheckedVehicles
        public ActionResult Register()
        {
            return View(db.Vehicles.ToList());
        }

        // GET: IncheckedVehicles
        public ActionResult Index()
        {
            return View(db.Vehicles.ToList());
        }

        // GET: IncheckedVehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncheckedVehicle incheckedVehicle = db.Vehicles.Find(id);
            if (incheckedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(incheckedVehicle);
        }

        // GET: IncheckedVehicles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IncheckedVehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RegNr,Vtype,Brand,Model,Wheel,Status")] IncheckedVehicle incheckedVehicle)
        {
            incheckedVehicle.CheckOutTime = incheckedVehicle.CheckInTime=DateTime.Now;
            incheckedVehicle.Status = false;
            //incheckedVehicle.CheckOutTime = new DateTime() ;
            if (ModelState.IsValid)
            {
                db.Vehicles.Add(incheckedVehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(incheckedVehicle);
        }

        // GET: IncheckedVehicles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncheckedVehicle incheckedVehicle = db.Vehicles.Find(id);
            if (incheckedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(incheckedVehicle);
        }

        // POST: IncheckedVehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RegNr,Vtype,Brand,Model,Wheel,CheckInTime,CheckOutTime,Status")] IncheckedVehicle incheckedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(incheckedVehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(incheckedVehicle);
        }

        // GET: IncheckedVehicles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncheckedVehicle incheckedVehicle = db.Vehicles.Find(id);
            if (incheckedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(incheckedVehicle);
        }

        // POST: IncheckedVehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IncheckedVehicle incheckedVehicle = db.Vehicles.Find(id);
            db.Vehicles.Remove(incheckedVehicle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: IncheckedVehicles/Delete/5
        public ActionResult CheckOut(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncheckedVehicle incheckedVehicle = db.Vehicles.Find(id);
            if (incheckedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(incheckedVehicle);
        }

        // POST: IncheckedVehicles/Delete/5
        [HttpPost, ActionName("CheckOut")]
        [ValidateAntiForgeryToken]
        public ActionResult CheckOut(int id)
        {
            IncheckedVehicle incheckedVehicle = db.Vehicles.Find(id);
            incheckedVehicle.CheckOutTime = DateTime.Now;
            incheckedVehicle.Status = true;
            db.Entry(incheckedVehicle).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Search()
        {

            var query = from r in db.Vehicles select r;

            return View(query);

        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
