using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nail_in_nottingham.Models
{
    public class BookingModel
    {
        public SelectList Servicelistmodel { get; set; }
       
        public int booking_id { get; set; }
        public string consumer_first_name { get; set; }
        public string consumer_last_name { get; set; }
        [Required(ErrorMessage ="Contact Number is required")]
        public string consumer__mobileno { get; set; }
        public string consumer_email { get; set; }
        [Display(Name ="Service")]
        public int service_id { get; set; }

        public virtual Service Service { get; set; }

    
}
}