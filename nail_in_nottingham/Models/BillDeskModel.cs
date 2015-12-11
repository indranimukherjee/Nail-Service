using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nail_in_nottingham.Models
{
    public class BillDeskModel 
    {
        public SelectList Servicelistmodel { get; set; }
        public SelectList ServicePricemodel { get; set; }
        public SelectList ServiceDurationmodel { get; set; }
        public SelectList ServiceVariationmodel { get; set; }

        public int ID { get; set; }
        public int ServiceID { get; set; }
        public int ServiceDurationID { get; set; }
        public int ServicePriceID { get; set; }
        public int ServiceVeriationID { get; set; }

        public string ServiceAmount { get; set; }
        public int ServiceQuantity { get; set; }



        public virtual ICollection<booking> bookings { get; set; }

        public virtual ServiceMaster Service { get; set; }
        public virtual ServiceDuration ServiceDuration { get; set; }
        public virtual ServicePrice ServicePrice { get; set; }
        public virtual ServiceVariation ServiceVariation { get; set; }


    }
}