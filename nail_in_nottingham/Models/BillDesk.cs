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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillDesk()
        {
            bookings = new HashSet<booking>();
        }

        public int ID { get; set; }

        public int ServiceBilldeskId { get; set; }

        public int ServiceID { get; set; }

        public int ServiceDurationId { get; set; }

        [Required]
        public string ServiceTotalAmount { get; set; }

        public int NoOfPerson { get; set; }

        public virtual ServiceBillDesk ServiceBillDesk { get; set; }

        public virtual ServiceDuration ServiceDuration { get; set; }

        public virtual ServiceMaster ServiceMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<booking> bookings { get; set; }
    }
}
