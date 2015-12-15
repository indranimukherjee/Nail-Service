namespace nail_in_nottingham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServicePrice")]
    public partial class ServicePrice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServicePrice()
        {
            ServiceBillDesks = new HashSet<ServiceBillDesk>();
        }

        public int ID { get; set; }

        [Column("ServicePrice")]
        [Required]
        [StringLength(50)]
        public string ServicePrice1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceBillDesk> ServiceBillDesks { get; set; }
    }
}
