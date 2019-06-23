using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WeekendTask.DAL;
using WeekendTask.Models;

namespace WeekendTask.Areas.Admin.Controllers
{
    public class RecomentController : Controller
    {
        private TempleteContext db = new TempleteContext();

        // GET: Admin/Recoment
        public ActionResult Index()
        {
            return View(db.Recoments.ToList());
        }

        // GET: Admin/Recoment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recoment recoment = db.Recoments.Find(id);
            if (recoment == null)
            {
                return HttpNotFound();
            }
            return View(recoment);
        }

        // GET: Admin/Recoment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Recoment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Text,Name,Position")] Recoment recoment)
        {
            if (ModelState.IsValid)
            {
                db.Recoments.Add(recoment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recoment);
        }

        // GET: Admin/Recoment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recoment recoment = db.Recoments.Find(id);
            if (recoment == null)
            {
                return HttpNotFound();
            }
            return View(recoment);
        }

        // POST: Admin/Recoment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Text,Name,Position")] Recoment recoment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recoment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recoment);
        }

        // GET: Admin/Recoment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recoment recoment = db.Recoments.Find(id);
            if (recoment == null)
            {
                return HttpNotFound();
            }
            return View(recoment);
        }

        // POST: Admin/Recoment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recoment recoment = db.Recoments.Find(id);
            db.Recoments.Remove(recoment);
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
