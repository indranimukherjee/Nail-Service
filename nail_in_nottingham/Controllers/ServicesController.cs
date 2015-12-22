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
    public class ServicesController : Controller
    {


        // GET: Services
        public ActionResult Index()
        {
            NailModel db = new NailModel();

            List<ServiceBillDesk> serviceDetails = db.ServiceBillDesks.ToList();
          
            return View(serviceDetails);
        }
        public ActionResult About()
        {
            return View();
        }

    }
}

   