using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using nail_in_nottingham.Models;
using System.Web.WebPages.Html;

namespace nail_in_nottingham.Controllers
{
    public class bookingsController : Controller
    {
        private nail_serviceEntities db = new nail_serviceEntities();

        public nail_serviceEntities Db
        {
            get
            {
                return db;
            }

            set
            {
                db = value;
            }
        }

        public ActionResult Index()
        {

            nail_serviceEntities db = new nail_serviceEntities();
            //IEnumerable<SelectListItem> List =db.Services.Select( c => new SelectListItem
            //{
            //    Value = c.service_id.ToString(),

            //    text= c.service_type,
            // });

            //var model = new BookingModel;

            //return View(model);
            List<Service> objservicelist = (from Service in db.Services
                                            select Service).ToList();
            Service objservice = new Service();
            objservice.service_type = "---- Please Select ----";
            objservice.service_id = 0;
            objservicelist.Insert(0, objservice);
            SelectList objmodeldata = new SelectList(objservicelist, "service_id", "service_type", 0);
            ViewData["Servicelist"] = objmodeldata;
            BookingModel objBookingmodel = new BookingModel();
            objBookingmodel.Servicelistmodel = objmodeldata;
            return View(objBookingmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(BookingModel BOOK,int service_id)
        {
            if (ModelState.IsValid)
            {
               
                Db.bookings.Add(new booking
                {
                    booking_id = BOOK.booking_id,
                    consumer_first_name = BOOK.consumer_first_name,
                    consumer_last_name = BOOK.consumer_last_name,
                    consumer_email = BOOK.consumer_email,
                    consumer__mobileno = BOOK.consumer__mobileno,
                    service_id= Convert.ToInt32(BOOK.service_id)
                  


                });

                int i = db.SaveChanges();
                if (i > 0)
                {
                    ViewBag.ResultMessage = "BOOKING SUCCESSFUL";
                }
                //ViewData["Servicelist"] = new SelectList(db.Services, "service_id", "service_type", 0);

                return RedirectToAction("Index");
            }


            return View(BOOK);

        }
















    }
}
        // GET: bookings/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            booking booking = db.bookings.Find(id);
//            if (booking == null)
//            {
//                return HttpNotFound();
//            }
//            return View(booking);
//        }

//        // GET: bookings/Create
//        public ActionResult Create()
//        {
//            ViewBag.service_id = new SelectList(db.Services, "service_id", "service_type");
//            return View();
//        }

//        // POST: bookings/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "booking_id,consumer_first_name,consumer_last_name,consumer__mobileno,consumer_email,service_id")] booking booking)
//        {
//            if (ModelState.IsValid)
//            {
//                db.bookings.Add(booking);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.service_id = new SelectList(db.Services, "service_id", "service_type", booking.service_id);
//            return View(booking);
//        }

//        // GET: bookings/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            booking booking = db.bookings.Find(id);
//            if (booking == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.service_id = new SelectList(db.Services, "service_id", "service_type", booking.service_id);
//            return View(booking);
//        }

//        // POST: bookings/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "booking_id,consumer_first_name,consumer_last_name,consumer__mobileno,consumer_email,service_id")] booking booking)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(booking).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.service_id = new SelectList(db.Services, "service_id", "service_type", booking.service_id);
//            return View(booking);
//        }

//        // GET: bookings/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            booking booking = db.bookings.Find(id);
//            if (booking == null)
//            {
//                return HttpNotFound();
//            }
//            return View(booking);
//        }

//        // POST: bookings/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            booking booking = db.bookings.Find(id);
//            db.bookings.Remove(booking);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
