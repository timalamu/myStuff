using EricTim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EricTim.DAL
{
    public class TravelInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TravelContext>
    {
        protected override void Seed(TravelContext context)
        {
            var customers = new List<Customer>
            {
            new Customer{ AccountID= 1, FirstMidName="Eric",LastName="Yimele", Address="Balbrigan", DateOfBirth=DateTime.FromOADate(1900 - 10 - 25), PhoneNo="000",  NumberOfPassengers=1, FrequentDestination="Ndjamena", DestinationZone=DestinationZone.Africa },
            new Customer{ AccountID= 2, FirstMidName="Timothy",LastName="Alamu", Address="Newbridge", DateOfBirth=DateTime.FromOADate(1900 - 10 - 25), PhoneNo="001",  NumberOfPassengers=2, FrequentDestination="Brazil", DestinationZone=DestinationZone.SouthAmerica  },
            new Customer { AccountID= 3,FirstMidName = "Tim", LastName = "Alamu", Address = "Newbridge", DateOfBirth = DateTime.FromOADate(1900 - 10 - 25), PhoneNo = "023", NumberOfPassengers = 1, FrequentDestination = "Dublin", DestinationZone = DestinationZone.Europe },
            new Customer {AccountID= 4, FirstMidName = "Bob", LastName = "John", Address = "Tallaght", DateOfBirth = DateTime.FromOADate(2017 - 10 - 25), PhoneNo = "0233434", NumberOfPassengers = 1, FrequentDestination = "Cork", DestinationZone = DestinationZone.Europe },
            new Customer { AccountID= 5, FirstMidName = "Phil", LastName = "Alamu", Address = "Newbridge", DateOfBirth = DateTime.FromOADate(1900 - 10 - 25), PhoneNo = "023", NumberOfPassengers = 1, FrequentDestination = "Dublin", DestinationZone = DestinationZone.Europe },
            new Customer {AccountID= 6, FirstMidName = "Sam", LastName = "John", Address = "Tallaght", DateOfBirth = DateTime.FromOADate(2017 - 10 - 25), PhoneNo = "0233434", NumberOfPassengers = 1, FrequentDestination = "Cork", DestinationZone = DestinationZone.Europe }

            };
            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();
            var bookings = new List<Booking>
            {
             new Booking { BookingID = 011, AccountID = 1, DateOfBooking = DateTime.FromOADate(1900 - 10 - 25), PassengerName = "Tim Alamu", DepartureDate=DateTime.FromOADate(1900 - 10 - 25), ReturnDate = DateTime.FromOADate(1900 - 10 - 25), NumberOfPassengers = 2, PointOfOrigin="Dublin", Destination = "Chicago", FlightDuration = 2,  },
             new Booking { BookingID = 003, AccountID = 1, DateOfBooking = DateTime.FromOADate(1900 - 10 - 25), PassengerName = "Alamu", DepartureDate = DateTime.FromOADate(1900 - 10 - 25), ReturnDate = DateTime.FromOADate(1900 - 10 - 25), NumberOfPassengers = 2, PointOfOrigin = "Dublin", Destination = "London", FlightDuration = 2 },
             new Booking { BookingID = 004, AccountID = 1, DateOfBooking = DateTime.FromOADate(1900 - 11 - 25), PassengerName = "Lee Harvey", DepartureDate = DateTime.FromOADate(2017 - 10 - 25), ReturnDate = DateTime.FromOADate(1900 - 11 - 25), NumberOfPassengers = 2, PointOfOrigin = "London", Destination = "Bilbao", FlightDuration = 2  },
             new Booking { BookingID = 006, AccountID = 1, DateOfBooking = DateTime.FromOADate(1900 - 10 - 25), PassengerName = "Alamu", DepartureDate = DateTime.FromOADate(1900 - 10 - 25), ReturnDate = DateTime.FromOADate(1900 - 10 - 25), NumberOfPassengers = 2, PointOfOrigin = "Dublin", Destination = "London", FlightDuration = 2 },
             new Booking { BookingID = 005, AccountID = 1, DateOfBooking = DateTime.FromOADate(2000 - 11 - 25), PassengerName = "Lee Harvey", DepartureDate = DateTime.FromOADate(20-10-2015), ReturnDate = DateTime.FromOADate(1900 - 11 - 25), NumberOfPassengers = 2, PointOfOrigin = "London", Destination = "Bilbao", FlightDuration = 2  }

            };
            bookings.ForEach(b => context.Bookings.Add(b));
            context.SaveChanges();
            var customerbookings = new List<CustomerBooking>
            {
                new CustomerBooking {TableID=001, }
            };
            customerbookings.ForEach(s => context.CustomerBookings.Add(s));
            context.SaveChanges();
        }
    }
}