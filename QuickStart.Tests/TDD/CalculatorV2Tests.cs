using NUnit.Framework;
using QuickStart.TDD;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickStart.Tests.TDD
{
    class CalculatorV2Tests
    {
        [Test]
        public void GetMin_FirstArgumentIsBigger_ReturnsSecondArgument()
        {
            var calculator = new CalculatorV2();

            var result = calculator.GetMin(2, 1);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void GetMin_SecondArgumentIsBigger_ReturnsFirstArgument()
        {
            var calculator = new CalculatorV2();

            var result = calculator.GetMin(1, 2);

            Assert.That(result, Is.EqualTo(1));
        }
    }
}
