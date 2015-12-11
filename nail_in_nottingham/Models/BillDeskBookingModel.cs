using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nail_in_nottingham.Models
{
    public class BillDeskBookingModel
    {
        public int ID { get; set; }
        public int ServiceBilldeskId { get; set; }
        public int ServiceID { get; set; }
        public int ServiceDurationId { get; set; }
        public string ServiceTotalAmount { get; set; }
        public int NoOfPerson { get; set; }

        public virtual ServiceBillDesk ServiceBillDesk { get; set; }
        public virtual ServiceDuration ServiceDuration { get; set; }
        public virtual ServiceMaster ServiceMaster { get; set; }
        public virtual ICollection<booking> bookings { get; set; }
    }
}