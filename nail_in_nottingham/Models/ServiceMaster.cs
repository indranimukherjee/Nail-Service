namespace nail_in_nottingham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceMaster")]
    public partial class ServiceMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceMaster()
        {
            BillDesks = new HashSet<BillDesk>();
            ServiceBillDesks = new HashSet<ServiceBillDesk>();
       
        }

        public int ID { get; set; }

        [Required]
        public string ServiceType { get; set; }

        public string ServiceDesc { get; set; }

     

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDesk> BillDesks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceBillDesk> ServiceBillDesks { get; set; }



    }
}
