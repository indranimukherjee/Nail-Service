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
        private NailModel db = new NailModel();



        public ActionResult Index(int SBId = 0)
        {

            NailModel db = new NailModel();

            List<SelectedItem> selectedItemList = new List<SelectedItem>();

            for (int i = 0; i < 15; i++) {
                selectedItemList.Add(new SelectedItem());               
            }



            if (SBId > 0)
            {
                ServiceBillDesk serviceBillDeskItem = db.ServiceBillDesks.Find(SBId);
                if (serviceBillDeskItem != null)
                {
                    //SelectedItem item = new SelectedItem();
                    selectedItemList[0].ServiceName = serviceBillDeskItem.ServiceMaster.ServiceType;
                    selectedItemList[0].serviceVeriation = serviceBillDeskItem.ServiceVeriation.ServiceVariation;
                    selectedItemList[0].timeDuration = serviceBillDeskItem.ServiceDuration;
                    selectedItemList[0].price = serviceBillDeskItem.ServicePrice;
                    selectedItemList[0].NoOfPerson = serviceBillDeskItem.ServiceQuantity;
                    selectedItemList[0].ServiceBillDeskId = serviceBillDeskItem.ID;
                    //selectedItemList.Add(item);
                    ViewBag.IsItems = true;
                    //ViewBag.ServiceItem = serviceBillDeskItem;
                }

            }




            BookingViewModel bookingViewModel = new BookingViewModel();

            bookingViewModel.bookingServices = new booking();

            bookingViewModel.serviceBillDeskDetails = db.ServiceBillDesks.ToList();

            bookingViewModel.SelectedItem = selectedItemList;

            // db.ServiceBillDesks.Where(x => x.ServiceMaster.ParentServiceId>0).GroupBy(s => s.ServiceID).ToList();

            return View(bookingViewModel);

        }

        [HttpPost]
        public ActionResult Index(BookingViewModel bookinfo)
        {
            BookingViewModel bookingViewModel = new BookingViewModel();

            bookingViewModel.bookingServices = new booking();

            bookingViewModel.serviceBillDeskDetails = db.ServiceBillDesks.ToList();

            bookingViewModel.SelectedItem = null;
           
            return View(bookingViewModel);

        }
    }
}
//[HttpPost]
//        [ValidateAntiForgeryToken]
        //public ActionResult Index(booking BOOK, FormCollection frm, string SlotType)
        //{
        //    //int serviceId = Convert.ToInt32(frm["Servicelist"].ToString());

        //    if (ModelState.IsValid)
        //    {

        //        db.bookings.Add(new booking
        //        {
        //            //booking_id = BOOK.booking_id,
        //            consumer_first_name = BOOK.consumer_first_name,
        //            consumer_last_name = BOOK.consumer_last_name,
        //            consumer_email = BOOK.consumer_email,
        //            consumer__mobileno = BOOK.consumer__mobileno,
        //            //service_id = serviceId,
        //            booking_date = Convert.ToDateTime(BOOK.booking_date),
        //            SlotID = Convert.ToInt32(BOOK.SlotID),
        //            //BillDeskID = Convert.ToInt32(BOOK.ServiceBillDeskID),
        //            TotalAmount = BOOK.TotalAmount,
        //            TotalQuantity = Convert.ToInt32(BOOK.TotalQuantity)
        //        });

        //        int i = db.SaveChanges();
        //        if (i > 0)
        //        {
        //            ViewBag.ResultMessage = "BOOKING SUCCESSFUL";
        //        }

        //        return RedirectToAction("Index");
        //    }


        //    return View(BOOK);

        //}
