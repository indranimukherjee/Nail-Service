using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nail_in_nottingham.Models;

namespace nail_in_nottingham.Controllers
{
    public class HomeController : Controller
    {
        private nail_serviceEntities _db = new nail_serviceEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Service()
        {
            ViewBag.Message = "Your Service page.";

            return View();
        }

        public ActionResult Service()
        {
            ViewBag.Message = "Your Service page.";

            return View();
        }

        public ActionResult Booking()
        {

            ViewBag.Message = "Your Booking page.";

            return View();
        }
        public ActionResult Payment()
        {
            ViewBag.Message = "Your Payment page.";

            return View();
        }
        public ActionResult gallery()
        {
            ViewBag.Message = "Your gallery page.";

            return View();
        }
    }
}