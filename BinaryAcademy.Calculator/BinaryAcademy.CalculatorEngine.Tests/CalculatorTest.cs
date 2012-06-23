using BinaryAcademy.CalculatorEngine.Core;
using NUnit.Framework;

namespace BinaryAcademy.CalculatorEngine.Tests
{
    [TestFixture]
    public class SimpleCalculatorTest
    {
        private readonly SimpleCalculator calculator = new SimpleCalculator();

        [Test]
        public void Should_ResultEqual7_WhenAdd3And4()
        {
            Assert.AreEqual(7, calculator.Add(3, 4), 10e-4);
        }

        [Test]
        public void Should_ResultEqual9_WhenSubtract5From14()
        {
            Assert.AreEqual(9, calculator.Subtract(14, 5), 10e-4);
        }

        [Test]
        public void Should_ResultEqual15_WhenMyltiply5And3()
        {
            Assert.AreEqual(15, calculator.Myltiply(5, 3), 10e-4);
        }

        [Test]
        public void Should_ResultEqual11_WhenDivide33By3()
        {
            Assert.AreEqual(11, calculator.Divide(33, 3), 10e-4);
        }

        [Test]
        public void Should_RaiseDivideByZeroException_WhenDivideByZero()
        {
            Assert.Throws<System.DivideByZeroException>(() => calculator.Divide(7, 0));
        }
    }
}
