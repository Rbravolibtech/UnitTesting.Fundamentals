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

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {

            var math = new Math();

           var result =  math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
            public void Max_SecondArgumentISGreater_ReturnTheSecondArgument()
            {

            var math = new Math();

            var result = math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentAreEqual_ReturnTheSameArgument()
        {

            var math = new Math();

            var result = math.Max(1, 1);

            Assert.That(result, Is.EqualTo(1));
        }

    }
}      