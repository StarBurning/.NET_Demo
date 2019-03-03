using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    [Authorize]
    public class firstdtsController : Controller
    {
        private mvcdemodbEntities db = new mvcdemodbEntities();

        // GET: firstdts
        public ActionResult Index()
        {
            return View(db.firstdt.ToList());
        }

        // GET: firstdts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            firstdt firstdt = db.firstdt.Find(id);
            if (firstdt == null)
            {
                return HttpNotFound();
            }
            return View(firstdt);
        }

        // GET: firstdts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: firstdts/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Age,Add_Date")] firstdt firstdt)
        {
            if (ModelState.IsValid)
            {
                db.firstdt.Add(firstdt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(firstdt);
        }

        // GET: firstdts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            firstdt firstdt = db.firstdt.Find(id);
            if (firstdt == null)
            {
                return HttpNotFound();
            }
            return View(firstdt);
        }

        // POST: firstdts/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Age,Add_Date")] firstdt firstdt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(firstdt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(firstdt);
        }

        // GET: firstdts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            firstdt firstdt = db.firstdt.Find(id);
            if (firstdt == null)
            {
                return HttpNotFound();
            }
            return View(firstdt);
        }

        // POST: firstdts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            firstdt firstdt = db.firstdt.Find(id);
            db.firstdt.Remove(firstdt);
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
