namespace nail_in_nottingham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("booking")]
    public partial class booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public booking()
        {
            BillDesks = new HashSet<BillDesk>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string consumer_first_name { get; set; }

        [Required]
        [StringLength(50)]
        public string consumer_last_name { get; set; }

        [Required]
        [StringLength(15)]
        public string consumer__mobileno { get; set; }

        [Required]
        [StringLength(50)]
        public string consumer_email { get; set; }

        [Column(TypeName = "date")]
        public DateTime booking_start_datetime { get; set; }

        public DateTime booking_end_datetime { get; set; }

        [Required]
        public string TotalAmount { get; set; }

        public int TotalQuantity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDesk> BillDesks { get; set; }
    }
}
