using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Market.Models;

namespace Market.Controllers
{
    public class BookimagesController : Controller
    {
        private BooksDBContext db = new BooksDBContext();

        // GET: Bookimages
        public ActionResult Index()
        {
            return View(db.Bookimage.ToList());
        }

        // GET: Bookimages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bookimage bookimage = db.Bookimage.Find(id);
            if (bookimage == null)
            {
                return HttpNotFound();
            }
            return View(bookimage);
        }

        // GET: Bookimages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bookimages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "userID,ISBN,imgPath")] Bookimage bookimage)
        {
            if (ModelState.IsValid)
            {
                db.Bookimage.Add(bookimage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookimage);
        }

        // GET: Bookimages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bookimage bookimage = db.Bookimage.Find(id);
            if (bookimage == null)
            {
                return HttpNotFound();
            }
            return View(bookimage);
        }

        // POST: Bookimages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "userID,ISBN,imgPath")] Bookimage bookimage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookimage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookimage);
        }

        // GET: Bookimages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bookimage bookimage = db.Bookimage.Find(id);
            if (bookimage == null)
            {
                return HttpNotFound();
            }
            return View(bookimage);
        }

        // POST: Bookimages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bookimage bookimage = db.Bookimage.Find(id);
            db.Bookimage.Remove(bookimage);
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
