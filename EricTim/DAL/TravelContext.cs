using EricTim.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EricTim.DAL
{
    public class TravelContext : DbContext
    {
        public TravelContext() : base("TravelContext")
        {
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<CustomerBooking> CustomerBookings { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}