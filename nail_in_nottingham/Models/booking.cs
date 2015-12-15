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
        [Key]
        public int booking_id { get; set; }

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
        public DateTime booking_date { get; set; }

        public int SlotID { get; set; }

        public int BillDeskID { get; set; }

        [Required]
        public string TotalAmount { get; set; }

        public int TotalQuantity { get; set; }

        public virtual BillDesk BillDesk { get; set; }

        public virtual Slot Slot { get; set; }
    }
}
