using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controllers
{
    public class SchoolsController : Controller
    {
        private DBSchoolEntities db = new DBSchoolEntities();

        // GET: Schools
        public ActionResult Index()
        {
            return View(db.tblSchools.ToList());
        }

        // GET: Schools/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSchool tblSchool = db.tblSchools.Find(id);
            if (tblSchool == null)
            {
                return HttpNotFound();
            }
            return View(tblSchool);
        }

        // GET: Schools/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Schools/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SchoolName,Logo,AddressLine1,AddressLine2,AddressLine3,City,State,Country,Pincode,ContactNo1,ContactNo2,EmailId,StartingYear,CreateDate,UpdateDate")] tblSchool tblSchool)
        {
            if (ModelState.IsValid)
            {
                db.tblSchools.Add(tblSchool);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblSchool);
        }

        // GET: Schools/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSchool tblSchool = db.tblSchools.Find(id);
            if (tblSchool == null)
            {
                return HttpNotFound();
            }
            return View(tblSchool);
        }

        // POST: Schools/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SchoolName,Logo,AddressLine1,AddressLine2,AddressLine3,City,State,Country,Pincode,ContactNo1,ContactNo2,EmailId,StartingYear,CreateDate,UpdateDate")] tblSchool tblSchool)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblSchool).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblSchool);
        }

        // GET: Schools/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSchool tblSchool = db.tblSchools.Find(id);
            if (tblSchool == null)
            {
                return HttpNotFound();
            }
            return View(tblSchool);
        }

        // POST: Schools/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            tblSchool tblSchool = db.tblSchools.Find(id);
            db.tblSchools.Remove(tblSchool);
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
