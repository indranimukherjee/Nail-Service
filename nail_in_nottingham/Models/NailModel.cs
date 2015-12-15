namespace nail_in_nottingham.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NailModel : DbContext
    {
     
    
        public NailModel() : base("name=NailModel")
        {
            //Database.SetInitializer<NailModel>(new DropCreateDatabaseIfModelChanges<NailModel>());
        }

        public virtual DbSet<BillDesk> BillDesks { get; set; }
        public virtual DbSet<booking> bookings { get; set; }
        public virtual DbSet<ServiceBillDesk> ServiceBillDesks { get; set; }
        public virtual DbSet<ServiceDuration> ServiceDurations { get; set; }
        public virtual DbSet<ServiceMaster> ServiceMasters { get; set; }
        public virtual DbSet<ServicePrice> ServicePrices { get; set; }
        public virtual DbSet<ServiceVeriation> ServiceVeriations { get; set; }
        public virtual DbSet<Slot> Slots { get; set; }
        public virtual DbSet<visitor> visitors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillDesk>()
                .HasMany(e => e.bookings)
                .WithRequired(e => e.BillDesk)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<ServiceDuration>()
                .HasMany(e => e.BillDesks)
                .WithRequired(e => e.ServiceDuration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceDuration>()
                .HasMany(e => e.ServiceBillDesks)
                .WithRequired(e => e.ServiceDuration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceMaster>()
                .HasMany(e => e.BillDesks)
                .WithRequired(e => e.ServiceMaster)
                .HasForeignKey(e => e.ServiceID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceMaster>()
                .HasMany(e => e.ServiceBillDesks)
                .WithRequired(e => e.ServiceMaster)
                .HasForeignKey(e => e.ServiceID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServicePrice>()
                .HasMany(e => e.ServiceBillDesks)
                .WithRequired(e => e.ServicePrice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceVeriation>()
                .HasMany(e => e.ServiceBillDesks)
                .WithRequired(e => e.ServiceVeriation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Slot>()
                .HasMany(e => e.bookings)
                .WithRequired(e => e.Slot)
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
