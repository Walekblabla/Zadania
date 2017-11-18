using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ListaZakupow.Models;

namespace ListaZakupow.Controllers
{
    public class ListModelsController : Controller
    {
        private Models.AppContext db = new Models.AppContext();

        // GET: ListModels
        public ActionResult Index()
        {
            return View(db.ListModels.ToList());
        }

        // GET: ListModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListModel listModel = db.ListModels.Find(id);
            if (listModel == null)
            {
                return HttpNotFound();
            }
            return View(listModel);
        }

        // GET: ListModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ListModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Date")] ListModel listModel)
        {
            if (ModelState.IsValid)
            {
                listModel.Date = DateTime.Now;
                listModel.LastEdit = DateTime.Now;
                db.ListModels.Add(listModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(listModel);
        }

        // GET: ListModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListModel listModel = db.ListModels.Find(id);
            if (listModel == null)
            {
                return HttpNotFound();
            }
            return View(listModel);
        }

        // POST: ListModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Date")] ListModel listModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(listModel).State = EntityState.Modified;
                listModel.LastEdit = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(listModel);
        }

        // GET: ListModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListModel listModel = db.ListModels.Find(id);
            if (listModel == null)
            {
                return HttpNotFound();
            }
            return View(listModel);
        }

        // POST: ListModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ListModel listModel = db.ListModels.Find(id);
            db.ListModels.Remove(listModel);
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
