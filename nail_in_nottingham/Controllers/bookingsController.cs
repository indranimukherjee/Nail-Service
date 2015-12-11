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
using nail_in_nottingham.ViewModels;

namespace nail_in_nottingham.Controllers
{
    public class bookingsController : Controller
    {
        private nail_serviceEntities db = new nail_serviceEntities();





        public ActionResult Index(int Sid = 0)
        {

            nail_serviceEntities db = new nail_serviceEntities();




            BookingViewModel bookingViewModel = new BookingViewModel();

            bookingViewModel.bookingServices = new booking();

            bookingViewModel.serviceBillDeskDetails = db.ServiceBillDesks.Where(x => x.ServiceMaster.ParentServiceId > 0).ToList();

            // db.ServiceBillDesks.Where(x => x.ServiceMaster.ParentServiceId>0).GroupBy(s => s.ServiceID).ToList();

            return View(bookingViewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(BookingModel BOOK, FormCollection frm, string SlotType)
        {
            //int serviceId = Convert.ToInt32(frm["Servicelist"].ToString());

            if (ModelState.IsValid)
            {

                db.bookings.Add(new booking
                {
                    //booking_id = BOOK.booking_id,
                    consumer_first_name = BOOK.consumer_first_name,
                    consumer_last_name = BOOK.consumer_last_name,
                    consumer_email = BOOK.consumer_email,
                    consumer__mobileno = BOOK.consumer__mobileno,
                    //service_id = serviceId,
                    booking_date = Convert.ToDateTime(BOOK.booking_date),
                    SlotID = Convert.ToInt32(BOOK.SlotID),
                    //BillDeskID = Convert.ToInt32(BOOK.ServiceBillDeskID),
                    TotalAmount = BOOK.TotalAmount,
                    TotalQuantity = Convert.ToInt32(BOOK.TotalQuantity)
                });

                int i = db.SaveChanges();
                if (i > 0)
                {
                    ViewBag.ResultMessage = "BOOKING SUCCESSFUL";
                }

                return RedirectToAction("Index");
            }


            return View(BOOK);

        }

    }
}