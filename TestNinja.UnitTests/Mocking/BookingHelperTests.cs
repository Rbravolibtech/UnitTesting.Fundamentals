using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class BookingHelper_OverlappingBookingExistTests
    {
        [Test]
        public void BookingStartsAndFinishesBeforeAnExisitngBooking_ReturnEmptyString()
        {
            var repository = new Mock<IBookingRepository>();
            repository.Setup(r => r.GetActiveBookings(1)).Returns(new List<Booking>
                {
                new Booking
                {
                    ArrivalDate = new DateTime(2017, 1, 15, 14, 0, 0),
                    DepartureDate = new DateTime(2017, 1, 20, 10, 0, 0),
                    Reference = "a"
                }
                //The .AsQueryable() is used to convert the List<Booking> into an IQueryable<Booking
                
            }.AsQueryable());

           var result =  BookingHelper.OverlappingBookingsExist(new Booking
            {
                Id = 1,
                ArrivalDate = new DateTime(2017, 1, 15, 14, 0, 0),
                DepartureDate = new DateTime(2017, 1, 14, 10, 0, 0),
            }, repository.Object);

            Assert.That(result, Is.Empty);
        }

    }

        
}





    

  