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

            //Total No of serviceItems selected
            for (int i = 0; i < 15; i++)
            {
                selectedItemList.Add(new SelectedItem());

            }



            if (SBId > 0)
            {
                ServiceBillDesk serviceBillDeskItem = db.ServiceBillDesks.Find(SBId);
                if (serviceBillDeskItem != null)
                {

                    // SelectedItem item = new SelectedItem();
                    selectedItemList[0].ServiceName = serviceBillDeskItem.ServiceMaster.ServiceType;
                    selectedItemList[0].serviceVeriation = serviceBillDeskItem.ServiceVeriation.ServiceVariation;
                    selectedItemList[0].timeDuration = serviceBillDeskItem.ServiceDuration;
                    selectedItemList[0].price = serviceBillDeskItem.ServicePrice;
                    selectedItemList[0].NoOfPerson = serviceBillDeskItem.ServiceQuantity;
                    selectedItemList[0].ServiceBillDeskId = serviceBillDeskItem.ID;
                    //selectedItemList.Add(item);

                    //ViewBag.ServiceItem = serviceBillDeskItem;
                    ViewBag.IsItems = true;
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

        public ActionResult Index(List<SelectedItem> selItems, booking bookingDetails, FormCollection frm)
        {
            string tset = Convert.ToString(frm["testValue"]);
            BookingViewModel bookingViewModel = new BookingViewModel();

            bookingViewModel.bookingServices = new booking();

            bookingViewModel.serviceBillDeskDetails = db.ServiceBillDesks.ToList();

            bookingViewModel.SelectedItem = selItems;

            return View(bookingViewModel);
        }


        [HttpPost]
        public JsonResult Submit(booking bookingDetails)
        {
            booking bookDetailsItems = new booking()
            {
                consumer_first_name = bookingDetails.consumer_first_name,
                consumer_last_name = bookingDetails.consumer_last_name,
                consumer_email = bookingDetails.consumer_email,
                consumer__mobileno = bookingDetails.consumer__mobileno,
                booking_start_datetime = bookingDetails.booking_start_datetime,
                booking_end_datetime = bookingDetails.booking_end_datetime,
                TotalQuantity = bookingDetails.TotalQuantity,
                TotalAmount = bookingDetails.TotalAmount
            };
            db.bookings.Add(bookingDetails);
            db.SaveChanges();
            return Json("Response from Create" + bookDetailsItems.ID);
        }

    }
}
