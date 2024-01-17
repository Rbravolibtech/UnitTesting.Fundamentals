using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {

        //Adding this line of code below allows to make less repeatable code 
        private Math _math;

        //setUp
        //tearDown

        public void SetUP()
        {
            _math = new Math();
        }




        [Test]
        public void Add_WhenCalled_ReturneTheSumOfArguments()

        {

            //This code below may be deleted when adding the code above _math = new Math();

            //var math = new Math();

            //We want to use simple values so we dont confuse others such as 1 and 2 not 952


            _math.Add(1, 2);

            bool result = false;
            Assert.That(result, Is.EqualTo(3));

        }
        //This line indicates the start of a test method named 
        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            //var math = new Math();: Creates an instance of a class named Math


            //var math = new Math();

            //var result = math.Max(2, 1);: Calls the Max method of the math object with
            //arguments 2 and 1, storing the result in the result variable.

            var result =  _math.Max(2, 1);

            //Assert.That(result, Is.EqualTo(2));: Uses an assertion to check whether the result
            //is equal to 2.
            //If this condition is true, the test passes; otherwise, it fails.

            Assert.That(result, Is.EqualTo(2));
        }

        //This line indicates the start of a test method named second method
        [Test]
            public void Max_SecondArgumentISGreater_ReturnTheSecondArgument()
            {

            //var math = new Math();

            var result = _math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        //This line indicates the start of a test method named 3rd method
        [Test]
        public void Max_ArgumentAreEqual_ReturnTheSameArgument()
        {

            //var math = new Math();

            var result = _math.Max(1, 1);

            Assert.That(result, Is.EqualTo(1));
        }

    }
}      