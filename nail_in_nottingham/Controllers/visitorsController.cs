using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using nail_in_nottingham.Models;

namespace nail_in_nottingham.Controllers
{
    public class visitorsController : Controller
    {
        private nail_serviceEntities db = new nail_serviceEntities();

        // GET: visitors
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(VisitorModel visitors)
        {
            if (ModelState.IsValid)
            {
              

                db.visitors.Add(new visitor
                {
                    vstr_id = visitors.vstr_id,
                    visitor_name = visitors.visitor_name,
                    visitor_location = visitors.visitor_location,
                    visitor_phoneno = visitors.visitor_phoneno,
                    visitor_email = visitors.visitor_email,
                    visitor_comment_desc = visitors.visitor_comment_desc
                });
                int i = db.SaveChanges();
                if (i > 0)
                {
                    ViewBag.ResultMessage = "data Saved Successfully";
                }
                return RedirectToAction("Index");
            }
            return View(visitors);
        }


        // GET: visitors/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    visitor visitor = db.visitors.Find(id);
        //    if (visitor == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(visitor);
        //}

        //// GET: visitors/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: visitors/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "vstr_id,visitor_name,visitor_location,visitor_phoneno,visitor_email,visitor_comment_desc")] visitor visitor)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.visitors.Add(visitor);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(visitor);
        //}

        //// GET: visitors/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    visitor visitor = db.visitors.Find(id);
        //    if (visitor == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(visitor);
        //}

        //// POST: visitors/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "vstr_id,visitor_name,visitor_location,visitor_phoneno,visitor_email,visitor_comment_desc")] visitor visitor)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(visitor).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(visitor);
        //}

        //// GET: visitors/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    visitor visitor = db.visitors.Find(id);
        //    if (visitor == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(visitor);
        //}

        //// POST: visitors/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    visitor visitor = db.visitors.Find(id);
        //    db.visitors.Remove(visitor);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
