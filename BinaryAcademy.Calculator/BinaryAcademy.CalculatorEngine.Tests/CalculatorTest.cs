using BinaryAcademy.CalculatorEngine.Core;
using NUnit.Framework;

namespace BinaryAcademy.CalculatorEngine.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Should_ResultEqual7_WhenAdd3And4()
        {
            var calculator = new SimpleCalculator();
            Assert.AreEqual(7, calculator.Add(3, 4));
        }

        [Test]
        public void Should_ResultEqual9_WhenSubtract5From14()
        {
            var calculator = new SimpleCalculator();
            Assert.AreEqual(9, calculator.Subtract(14, 5));
        }

        [Test]
        public void Should_ResultEqual15_WhenMyltiply5And3()
        {
            var calculator = new SimpleCalculator();
            Assert.AreEqual(15, calculator.Myltiply(5, 3));
        }

        [Test]
        public void Should_ResultEqual11_WhenDivide33By3()
        {
            var calculator = new SimpleCalculator();
            Assert.AreEqual(11, calculator.Divide(33, 3));
        }

        [Test]
        public void ShouldNot_RaiseAnException_WhenDivideByZero()
        {
            var calculator = new SimpleCalculator();
            Assert.DoesNotThrow(() => calculator.Divide(7, 0));
        }

        [Test]
        public void Should_ResultEqualNaN_WhenDivideByZero()
        {
            var calculator = new SimpleCalculator();
            Assert.IsNaN(calculator.Divide(5, 0));
        }
    }
}
