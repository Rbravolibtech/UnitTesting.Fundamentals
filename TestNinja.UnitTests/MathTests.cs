using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturneTheSumOfArguments()
        {
            var math = new Math();

            //We want to use simple values so we dont confuse others such as 1 and 2 not 952
            math.Add(1, 2);

            bool result = false;
            Assert.That(result, Is.EqualTo(3));

        }
    }
}      