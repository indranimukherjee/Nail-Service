namespace nail_in_nottingham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("visitor")]
    public partial class visitor
    {
        [Key]
        public int vstr_id { get; set; }

        [Required]
        [StringLength(50)]
        public string visitor_name { get; set; }

        [Required]
        [StringLength(200)]
        public string visitor_location { get; set; }

        [Required]
        [StringLength(15)]
        //[RegularExpression(@"^(((\+44\s?\d{4}|\(?0\d{4}\)?)\s?\d{3}\s?\d{3})|((\+44\s?\d{3}|\(?0\d{3}\)?)\s?\d{3}\s?\d{4})|((\+44\s?\d{2}|\(?0\d{2}\)?)\s?\d{4}\s?\d{4}))(\s?\#(\d{4}|\d{3}))?$")]
        public string visitor_phoneno { get; set; }

        [Required]
        [StringLength(50)]
     
        [RegularExpression(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string visitor_email { get; set; }

        public string testimonials { get; set; }

        public string enquiry { get; set; }
        //public bool  IsSent  { get; set; }

    }
}
