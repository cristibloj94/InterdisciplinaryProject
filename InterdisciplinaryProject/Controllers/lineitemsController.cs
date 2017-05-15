using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InterdisciplinaryProject;

namespace InterdisciplinaryProject.Controllers
{
    public class lineitemsController : Controller
    {
        private imageDBEntities db = new imageDBEntities();

        // GET: lineitems
        public ActionResult Index()
        {
            return View(db.lineitems.ToList());
        }

        // GET: lineitems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lineitem lineitem = db.lineitems.Find(id);
            if (lineitem == null)
            {
                return HttpNotFound();
            }
            return View(lineitem);
        }

        // GET: lineitems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: lineitems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "lineitemid,name,price,description,imagePath")] lineitem lineitem)
        {
            if (ModelState.IsValid)
            {
                db.lineitems.Add(lineitem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lineitem);
        }

        // GET: lineitems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lineitem lineitem = db.lineitems.Find(id);
            if (lineitem == null)
            {
                return HttpNotFound();
            }
            return View(lineitem);
        }

        // POST: lineitems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "lineitemid,name,price,description,imagePath")] lineitem lineitem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lineitem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lineitem);
        }

        // GET: lineitems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lineitem lineitem = db.lineitems.Find(id);
            if (lineitem == null)
            {
                return HttpNotFound();
            }
            return View(lineitem);
        }

        // POST: lineitems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            lineitem lineitem = db.lineitems.Find(id);
            db.lineitems.Remove(lineitem);
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
