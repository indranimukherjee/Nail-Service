using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nail_in_nottingham.ViewModels
{
    public class SelectedItem
    {
        public string ServiceName { get; set; }
        public string serviceVeriation { get; set; }
        public string timeDuration { get; set; }

        public string price { get; set; }

        public int NoOfPerson { get; set; }
        public int ServiceBillDeskId { get; set; }
    }
}