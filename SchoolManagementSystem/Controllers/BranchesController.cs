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
    public class BranchesController : Controller
    {
        private DBSchoolEntities db = new DBSchoolEntities();

        // GET: Branches
        public ActionResult Index()
        {
            var tblBranches = db.tblBranches.Include(t => t.tblSchool);
            return View(tblBranches.ToList());
        }

        // GET: Branches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblBranch tblBranch = db.tblBranches.Find(id);
            if (tblBranch == null)
            {
                return HttpNotFound();
            }
            return View(tblBranch);
        }

        // GET: Branches/Create
        public ActionResult Create()
        {
            ViewBag.SchoolId = new SelectList(db.tblSchools, "Id", "SchoolName");
            return View();
        }

        // POST: Branches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BranchId,SchoolId,BranchName,AddressLine1,AddressLine2,AddressLine3,City,State,Country,Pincode,ContactNo1,ContactNo2,EmailId,StartingYear,CreateDate,UpdateDate")] tblBranch tblBranch)
        {
            if (ModelState.IsValid)
            {
                db.tblBranches.Add(tblBranch);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SchoolId = new SelectList(db.tblSchools, "Id", "SchoolName", tblBranch.SchoolId);
            return View(tblBranch);
        }

        // GET: Branches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblBranch tblBranch = db.tblBranches.Find(id);
            if (tblBranch == null)
            {
                return HttpNotFound();
            }
            ViewBag.SchoolId = new SelectList(db.tblSchools, "Id", "SchoolName", tblBranch.SchoolId);
            return View(tblBranch);
        }

        // POST: Branches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BranchId,SchoolId,BranchName,AddressLine1,AddressLine2,AddressLine3,City,State,Country,Pincode,ContactNo1,ContactNo2,EmailId,StartingYear,CreateDate,UpdateDate")] tblBranch tblBranch)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblBranch).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SchoolId = new SelectList(db.tblSchools, "Id", "SchoolName", tblBranch.SchoolId);
            return View(tblBranch);
        }

        // GET: Branches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblBranch tblBranch = db.tblBranches.Find(id);
            if (tblBranch == null)
            {
                return HttpNotFound();
            }
            return View(tblBranch);
        }

        // POST: Branches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblBranch tblBranch = db.tblBranches.Find(id);
            db.tblBranches.Remove(tblBranch);
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
