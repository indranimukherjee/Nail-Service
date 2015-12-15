using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using nail_in_nottingham.Models;

namespace nail_in_nottingham.ViewModels
{
    public class BookingViewModel
    {
        public List<ServiceBillDesk> serviceBillDeskDetails { get; set; }

        public booking bookingServices { get; set; }
    }
}