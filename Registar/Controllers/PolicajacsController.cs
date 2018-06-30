using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Registar.DAL;
using Registar.Models;

namespace Registar.Controllers
{
    [Authorize]
    public class PolicajacsController : Controller
    {
        private RegistarContext db = new RegistarContext();

        // GET: Policajacs
        public ActionResult Index()
        {
            return View(db.Policajac.ToList());
        }

        // GET: Policajacs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Policajac policajac = db.Policajac.Find(id);
            if (policajac == null)
            {
                return HttpNotFound();
            }
            return View(policajac);
        }

        // GET: Policajacs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Policajacs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PolicajacID,PolicajacIme,PolicajacPrezime")] Policajac policajac)
        {
            if (ModelState.IsValid)
            {
                db.Policajac.Add(policajac);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(policajac);
        }

        // GET: Policajacs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Policajac policajac = db.Policajac.Find(id);
            if (policajac == null)
            {
                return HttpNotFound();
            }
            return View(policajac);
        }

        // POST: Policajacs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PolicajacID,PolicajacIme,PolicajacPrezime")] Policajac policajac)
        {
            if (ModelState.IsValid)
            {
                db.Entry(policajac).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(policajac);
        }

        // GET: Policajacs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Policajac policajac = db.Policajac.Find(id);
            if (policajac == null)
            {
                return HttpNotFound();
            }
            return View(policajac);
        }

        // POST: Policajacs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Policajac policajac = db.Policajac.Find(id);
            db.Policajac.Remove(policajac);
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
