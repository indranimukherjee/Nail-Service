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
        private NailModel db = new NailModel();

        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(visitor visitors)
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
                    testimonials=visitors.testimonials,
                    enquiry=visitors.enquiry

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


    }
}
