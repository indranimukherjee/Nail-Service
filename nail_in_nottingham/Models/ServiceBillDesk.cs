namespace nail_in_nottingham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceBillDesk")]
    public partial class ServiceBillDesk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceBillDesk()
        {
            BillDesks = new HashSet<BillDesk>();
        }

        public int ID { get; set; }

        public int ServiceID { get; set; }

        public int ServiceDurationID { get; set; }

        public int ServicePriceID { get; set; }

        public int ServiceVeriationID { get; set; }

        [Required]
        public string ServiceAmount { get; set; }

        public int ServiceQuantity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDesk> BillDesks { get; set; }

        public virtual ServiceMaster ServiceMaster { get; set; }

        public virtual ServiceDuration ServiceDuration { get; set; }

        public virtual ServicePrice ServicePrice { get; set; }

        public virtual ServiceVeriation ServiceVeriation { get; set; }
    }
}
