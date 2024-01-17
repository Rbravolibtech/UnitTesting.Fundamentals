using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {

        //Test is what you will test on method
        [Test]

        //This is a test method named 
        public void GetOutput_InputIsDivisibleBy3And5_ReturnFizzBuzz()
        {

            //method of the FizzBuzz class with the input value 15.
            var result =   FizzBuzz.GetOutput(15);

            //This line performs an assertion to verify that the result obtained from calling fizzbuzz
            Assert.That(result, Is.EqualTo("FIzzBuzz"));
        }
        
        [Test]
        public void GetOutput_InputIsDivisibleBy3Only_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("FIzz"));
        }
        
        [Test]
        public void GetOutput_InputIsDivisibleBy5Only_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }
        
        [Test]
        public void GetOutput_InputIsNotDivisibleBy3Or5_ReturnTheSameNumber()
        {
            var result = FizzBuzz.GetOutput(1);

            Assert.That(result, Is.EqualTo("1"));
        }
        
    }
}