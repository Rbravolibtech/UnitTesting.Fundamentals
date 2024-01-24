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
        private Booking _booking;
        private Mock<IBookingRepository> _repository;

        [SetUp]
        public void SetUp()
        {
            _booking = new Booking
            {
                ArrivalDate = ArriveOn(2017, 1, 15),
                DepartureDate = DepartOn(2017, 1, 20),
                Reference = "a"
            };

             _repository = new Mock<IBookingRepository>();
            _repository.Setup(r => r.GetActiveBookings(1)).Returns(new List<Booking>
                {
                _booking

                //The .AsQueryable() is used to convert the List<Booking> into an IQueryable<Booking

            }.AsQueryable());
        }

        [Test]
        public void BookingStartsAndFinishesBeforeAnExisitngBooking_ReturnEmptyString()
        {
            

           var result =  BookingHelper.OverlappingBookingsExist(new Booking
            {
                Id = 1,
                ArrivalDate = ArriveOn(2017, 1, 15),
                DepartureDate = DepartOn(2017, 1, 14),
            }, _repository.Object);

            Assert.That(result, Is.Empty);
        }

        private DateTime ArriveOn(int year, int month, int day)
        {
            return new DateTime(year, month, day, 14, 0, 0);
        }

    }

        
}





    

  