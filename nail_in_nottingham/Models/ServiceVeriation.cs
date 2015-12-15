namespace nail_in_nottingham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceVeriation")]
    public partial class ServiceVeriation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceVeriation()
        {
            ServiceBillDesks = new HashSet<ServiceBillDesk>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ServiceVariation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceBillDesk> ServiceBillDesks { get; set; }
    }
}
