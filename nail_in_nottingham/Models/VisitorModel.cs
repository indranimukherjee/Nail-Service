using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nail_in_nottingham.Models
{
    public class VisitorModel
    {
        public int vstr_id { get; set; }
        public string visitor_name { get; set; }
        public string visitor_location { get; set; }
        public string visitor_phoneno { get; set; }
        public string visitor_email { get; set; }
        public string testimonials { get; set; }
        public string enquiry { get; set; }
    }
}