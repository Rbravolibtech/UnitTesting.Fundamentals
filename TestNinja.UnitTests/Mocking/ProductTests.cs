using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{

    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount()
        {
            var product = new Product { ListPrice = 100 };

            var result = product.GetPrice(new Customer { IsGold = true });

            Assert.That(result, Is.EqualTo(70));
        }

        [Test]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount2()
        {
            // Arrange

            // Creating a mock object for the ICustomer interface using Moq
            var customer = new Mock<ICustomer>();

            // Setting up the mock to return true for the IsGold property
            customer.Setup(c => c.IsGold).Returns(true);

            // Creating an instance of the Product class and setting its ListPrice to 100
            var product = new Product { ListPrice = 100 };

            // Act

            // Calling the GetPrice method on the Product instance, passing a Customer instance with IsGold set to true
            var result = product.GetPrice(new Customer { IsGold = true });

            // Assert

            // Verifying that the result is equal to the expected price after applying a 30% discount (70% of the ListPrice)
            Assert.That(result, Is.EqualTo(70));
        }
    }
}