using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Clinic2;

namespace Clinic2.Controllers
{
    public class display_available_slotsController : Controller
    {
        private ModelClinic db = new ModelClinic();

        // GET: display_available_slots
        public ActionResult Index()
        {
            return View(db.display_available_slots.ToList());
        }

        // GET: display_available_slots/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            display_available_slots display_available_slots = db.display_available_slots.Find(id);
            if (display_available_slots == null)
            {
                return HttpNotFound();
            }
            return View(display_available_slots);
        }

        // GET: display_available_slots/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: display_available_slots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TimeSoltId,Doctor,Start,End")] display_available_slots display_available_slots)
        {
            if (ModelState.IsValid)
            {
                db.display_available_slots.Add(display_available_slots);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(display_available_slots);
        }

        // GET: display_available_slots/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            display_available_slots display_available_slots = db.display_available_slots.Find(id);
            if (display_available_slots == null)
            {
                return HttpNotFound();
            }
            return View(display_available_slots);
        }

        // POST: display_available_slots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TimeSoltId,Doctor,Start,End")] display_available_slots display_available_slots)
        {
            if (ModelState.IsValid)
            {
                db.Entry(display_available_slots).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(display_available_slots);
        }

        // GET: display_available_slots/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            display_available_slots display_available_slots = db.display_available_slots.Find(id);
            if (display_available_slots == null)
            {
                return HttpNotFound();
            }
            return View(display_available_slots);
        }

        // POST: display_available_slots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            display_available_slots display_available_slots = db.display_available_slots.Find(id);
            db.display_available_slots.Remove(display_available_slots);
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
    }
}
