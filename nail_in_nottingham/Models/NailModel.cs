namespace nail_in_nottingham.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NailModel : DbContext
    {
        public NailModel()
            : base("name=NailModel")
        {
        }

        public virtual DbSet<BillDesk> BillDesks { get; set; }
        public virtual DbSet<booking> bookings { get; set; }
        public virtual DbSet<ServiceBillDesk> ServiceBillDesks { get; set; }
        public virtual DbSet<ServiceMaster> ServiceMasters { get; set; }
        public virtual DbSet<ServiceVeriation> ServiceVeriations { get; set; }
        public virtual DbSet<visitor> visitors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<booking>()
                .Property(e => e.consumer_first_name)
                .IsUnicode(false);

            modelBuilder.Entity<booking>()
                .Property(e => e.consumer_last_name)
                .IsUnicode(false);

            modelBuilder.Entity<booking>()
                .Property(e => e.consumer_email)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceBillDesk>()
                .HasMany(e => e.BillDesks)
                .WithRequired(e => e.ServiceBillDesk)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceMaster>()
                .HasMany(e => e.ServiceBillDesks)
                .WithRequired(e => e.ServiceMaster)
                .HasForeignKey(e => e.ServiceID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceVeriation>()
                .HasMany(e => e.ServiceBillDesks)
                .WithRequired(e => e.ServiceVeriation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<visitor>()
                .Property(e => e.visitor_name)
                .IsUnicode(false);

            modelBuilder.Entity<visitor>()
                .Property(e => e.visitor_location)
                .IsUnicode(false);
        }
    }
}
