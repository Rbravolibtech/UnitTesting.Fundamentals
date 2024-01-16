using System;
using TestNinja.Fundamentals;

namespace TestNinja;

[TestClass]
public class ReservationTests
{ 
    [TestMethod]
    public void CancelledBy_UserIsAdmin_ReturnsTrue()
    {

        //Arrange
        var reservation = new Reservation();

        //Act

      var result =   reservation.CanBeCancelledBy(new User { IsAdmin = true });

        //Assert

        //this is how u do a unit test below

        Assert.IsTrue(result);
    }
}
