using System;
using System.Security.Policy;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            // Arrange

            // set up the necessary conditions for the test
            var reservation = new Reservation();

            // Act
            // method on the reservation of an object with different user
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            // statement that checks the result of CanBeCancelledBy
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnTrue()
        {
            //You create a new instance of the User class, representing a user.
            //You create a new instance of the Reservation class and set its MadeBy

            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            //You call the CanBeCancelledBy method on the reservation object,
            //passing the user as an argument.
            //The method determines whether the user has the authority to cancel the
            //reservation and returns a boolean result.
            var result = reservation.CanBeCancelledBy(user);

            // this chedks if the result is True 
            Assert.IsTrue(result);
        }

        [Test]
        //You create a new instance of the User class, representing a user who made the reservation.
        // This simulates a reservation made by a specific user.
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };
            //The method determines whether the user attempting to cancel the reservation has the
            //authority to do so and returns a boolean result.
            var result = reservation.CanBeCancelledBy(new User());

            //this checks if the result is false 

            Assert.IsFalse(result);
        }
    }
}
