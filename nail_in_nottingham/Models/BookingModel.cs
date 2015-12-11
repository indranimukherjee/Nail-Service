using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace nail_in_nottingham.Models
{
    public class BookingModel : BillDeskModel
    {
        //public SelectList Servicelistmodel { get; set; }
        public SelectList Slotlistmodel { get; set; }
      

        public int booking_id { get; set; }
        public string consumer_first_name { get; set; }
        public string consumer_last_name { get; set; }
        [Display(Name = "Contact Number:")]
        public string consumer__mobileno { get; set; }
        public string consumer_email { get; set; }
        //[Display(Name ="Service:")]       
        public int BillDeskID { get; set; }

        public string TotalAmount { get; set; }
        public int TotalQuantity { get; set; }

        public string booking_date { get; set; }

        [Display(Name = "Pick A Slot")]
        public int SlotID { get; set; }

        //public virtual ServiceMaster Service { get; set; }
        public virtual BillDesk BillDesk { get; set; }

        public virtual Slot Slot { get; set; }



    }


}