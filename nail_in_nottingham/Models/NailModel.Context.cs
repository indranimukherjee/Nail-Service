﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace nail_in_nottingham.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class nail_serviceEntities : DbContext
    {
        public nail_serviceEntities()
            : base("name=nail_serviceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
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
    }
}