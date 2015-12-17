namespace nail_in_nottingham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillDesk")]
    public partial class BillDesk
    {
        public int ID { get; set; }

        public int ServiceBilldeskId { get; set; }

        public int NoOfPerson { get; set; }

        public int BookingID { get; set; }

        public virtual booking booking { get; set; }

        public virtual ServiceBillDesk ServiceBillDesk { get; set; }
    }
}
