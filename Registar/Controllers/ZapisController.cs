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
    public class ZapisController : Controller
    {
        private RegistarContext db = new RegistarContext();

        private void PopulateOsobaDropDownList(object selectedO = null)
        {
            var oQuery = from d in db.Osoba
                         
                         select d;
            ViewBag.OsobaID = new SelectList(oQuery, "OsobaID", "Ime" +" ", "Prezime", selectedO);
        }

        private void PopulatePolicajacDropDownList(object selectedP = null)
        {
            var pQuery = from d in db.Policajac
                         //orderby db.Policajac
                         select d;
            ViewBag.PolicajacID = new SelectList(pQuery, "PolicajacID", "PolicajacIme", "PolicajacPrezime", selectedP);
        }

        private void PopulatePrekrsajDropDownList(object selectedR = null)
        {
            var rQuery = from d in db.Prekrsaj
                         //orderby db.Prekrsaj
                         select d;
            ViewBag.PrekrsajID = new SelectList(rQuery, "PrekrsajID", "OpisPrekrsaja", selectedR);
        }


        public ActionResult Index()
        {
            var zapis = db.Zapis.Include(c => c.OsobaID);
            var zapis2 = zapis.Include(c => c.PolicajacID);
            var zapis3 = zapis2.Include(c => c.PrekrsajID);
            return View(zapis3.ToList());
        }


        public ActionResult Details(int id)
        {
            Zapis zapis = db.Zapis.Find(id);
            PopulateOsobaDropDownList(zapis.OsobaID);
            PopulatePolicajacDropDownList(zapis.PolicajacID);
            PopulatePrekrsajDropDownList(zapis.PrekrsajID);
            if (zapis == null)
            {
                return HttpNotFound();
            }
            return View(zapis);
        }

      
        public ActionResult Create()
        {
            PopulateOsobaDropDownList();
            PopulatePolicajacDropDownList();
            PopulatePrekrsajDropDownList();
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ZapisID,Datum,OsobaID_OsobaID,PolicajacID_PolicajacID,PrekrsajID_PrekrsajID")] Zapis zapis)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Zapis.Add(zapis);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");

            }
            PopulateOsobaDropDownList(zapis.OsobaID);
            PopulatePolicajacDropDownList(zapis.PolicajacID);
            PopulatePrekrsajDropDownList(zapis.PrekrsajID);

            return View(zapis);
        }

        // GET: Zapis1/Edit/5
        public ActionResult Edit(int id)
        {
            Zapis zapis = db.Zapis.Find(id);
            PopulateOsobaDropDownList(zapis.OsobaID);
            PopulatePolicajacDropDownList(zapis.PolicajacID);
            PopulatePrekrsajDropDownList(zapis.PrekrsajID);
            return View(zapis);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ZapisID,Datum,OsobaID_OsobaID,PolicajacID_PolicajacID,PrekrsajID_PrekrsajID")] Zapis zapis)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(zapis).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            PopulateOsobaDropDownList(zapis.OsobaID);
            PopulatePolicajacDropDownList(zapis.PolicajacID);
            PopulatePolicajacDropDownList(zapis.PrekrsajID);
            return View(zapis);
        }




        // GET: Zapis1/Delete/5
        public ActionResult Delete(int id)
        {
            Zapis zapis = db.Zapis.Find(id);
            if (zapis == null)
            {
                return HttpNotFound();
            }
            return View(zapis);
        }

     
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Zapis zapis = db.Zapis.Find(id);
            db.Zapis.Remove(zapis);
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

