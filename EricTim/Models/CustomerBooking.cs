using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EricTim.Models
{
    public class CustomerBooking
    {
        [Key]
        [Required]
        [Display(Name = "ID")]
        public int TableID { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Customer> Customers { get; set; }

    }
}