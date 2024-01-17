using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{

    //[TestFixture]: Indicates that the HtmlFormatterTests class is a test fixture containing unit tests
    [TestFixture]
    public class HtmlFormatterTests
    {

        //[Test]: Marks the method
        //FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement as a unit test.
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {

            //Creates an instance of the HtmlFormatter class.
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("Abc");

            // Specific
            Assert.That(result, Is.EqualTo("<stong>abc</strong>"));

            //more general

            //Specific Assertion: Checks if the result is exactly equal to

            Assert.That(result, Does.StartWith("<strong>"));

            Assert.That(result, Does.EndWith("</strong>"));

            Assert.That(result, Does.Contain("abc"));


            
        }
        
    }
}