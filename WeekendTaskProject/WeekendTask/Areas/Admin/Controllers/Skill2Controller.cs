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
    public class Skill2Controller : Controller
    {
        private TempleteContext db = new TempleteContext();

        // GET: Admin/Skill2
        public ActionResult Index()
        {
            return View(db.Skills2.ToList());
        }

        // GET: Admin/Skill2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skill2 skill2 = db.Skills2.Find(id);
            if (skill2 == null)
            {
                return HttpNotFound();
            }
            return View(skill2);
        }

        // GET: Admin/Skill2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Skill2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Percent")] Skill2 skill2)
        {
            if (ModelState.IsValid)
            {
                db.Skills2.Add(skill2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(skill2);
        }

        // GET: Admin/Skill2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skill2 skill2 = db.Skills2.Find(id);
            if (skill2 == null)
            {
                return HttpNotFound();
            }
            return View(skill2);
        }

        // POST: Admin/Skill2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Percent")] Skill2 skill2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(skill2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(skill2);
        }

        // GET: Admin/Skill2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skill2 skill2 = db.Skills2.Find(id);
            if (skill2 == null)
            {
                return HttpNotFound();
            }
            return View(skill2);
        }

        // POST: Admin/Skill2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Skill2 skill2 = db.Skills2.Find(id);
            db.Skills2.Remove(skill2);
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
