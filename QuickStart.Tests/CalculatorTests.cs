using NUnit.Framework;

namespace QuickStart.Tests
{
    public class CalculatorTests
    {

        [Test]
        public void GetMax_FirstArgumentIsBigger_ReturnsFirstArgument()
        {
            //arrange
            var calculator = new Calculator();

            //act
            var result = calculator.GetMax(2, 1);

            //assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void GetMax_SecondArgumentIsBigger_ReturnsSecondArgument()
        {
            //arrange
            var calculator = new Calculator();

            //act
            var result = calculator.GetMax(1, 2);

            //assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void GetMax_SameArgumentsArePassed_ReturnsFirstArgument()
        {
            //arrange
            var calculator = new Calculator();

            //act
            var result = calculator.GetMax(1, 1);

            //assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        [TestCase(1,2,2)]
        [TestCase(2,1,2)]
        [TestCase(1,1,1)]
        public void GetMax_WhenCalled_ReturnsMaxArgument(int a, int b, int expectedResult)
        {
            //arrange
            var calculator = new Calculator();

            //act
            var result = calculator.GetMax(a, b);

            //assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}