using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kontakt.Models;

namespace Kontakt.Controllers
{
    public class KontaktListsController : Controller
    {
        private Models.AppContext db = new Models.AppContext();

        // GET: KontaktLists
        public ActionResult Index()
        {
            return View(db.KontaktLists.ToList());
        }

        // GET: KontaktLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KontaktList kontaktList = db.KontaktLists.Find(id);
            if (kontaktList == null)
            {
                return HttpNotFound();
            }
            return View(kontaktList);
        }

        // GET: KontaktLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KontaktLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Mail,Temat,Tresc")] KontaktList kontaktList)
        {
            if (ModelState.IsValid)
            {
                db.KontaktLists.Add(kontaktList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kontaktList);
        }

        // GET: KontaktLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KontaktList kontaktList = db.KontaktLists.Find(id);
            if (kontaktList == null)
            {
                return HttpNotFound();
            }
            return View(kontaktList);
        }

        // POST: KontaktLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Mail,Temat,Tresc")] KontaktList kontaktList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kontaktList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kontaktList);
        }

        // GET: KontaktLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KontaktList kontaktList = db.KontaktLists.Find(id);
            if (kontaktList == null)
            {
                return HttpNotFound();
            }
            return View(kontaktList);
        }

        // POST: KontaktLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KontaktList kontaktList = db.KontaktLists.Find(id);
            db.KontaktLists.Remove(kontaktList);
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
