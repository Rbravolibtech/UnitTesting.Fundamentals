using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);

            //NOT FOUND
            Assert.That(result, Is.TypeOf<NotFound>());


            //NOT FOUND OR ONE OF THE DERIVATIVE 
            //Assert.That(result, Is.InstanceOf<NotFound
        }

        //PRACTICE TEST BELOW TOP IS EXAMPLE `````
        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            // Arrange

            //Arrange section, you create an instance of the CustomerController class.
            //This is the controller that you'll be testing.
            var controller = new CustomerController();

            // Act

            //The Act section involves calling a method or performing an action that you want to test.
            var result = controller.GetCustomer(1);

            // Assert

            //This is where you check if the behavior of the method matches your expectations.
            Assert.That(result, Is.TypeOf<RetryAttribute>());


        }

    }
}
