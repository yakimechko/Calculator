using BinaryAcademy.CalculatorEngine.Core;
using Moq;
using NUnit.Framework;

namespace BinaryAcademy.CalculatorEngine.Tests
{
    [TestFixture]
    class CalculatorEngineTest
    {
        [Test]
        public void Should_Output7Once_WhenAdding3And4()
        {
            var mock = new Mock<IDistributor>();
            var calcEngine = new CalcEngine(new SimpleCalculator(), mock.Object);
            calcEngine.Add(3, 4);
            mock.Verify(x => x.Write(7), Times.Once());
        }

        [Test]
        public void Should_Output5Once_WhenSubtact4From9()
        {
            var mock = new Mock<IDistributor>();
            var calcEngine = new CalcEngine(new SimpleCalculator(), mock.Object);
            calcEngine.Subtract(9, 4);
            mock.Verify(x => x.Write(5), Times.Once());
        }

        [Test]
        public void Should_Output21Once_WhenMultiply7By3()
        {
            var mock = new Mock<IDistributor>();
            var calcEngine = new CalcEngine(new SimpleCalculator(), mock.Object);
            calcEngine.Multiple(7, 3);
            mock.Verify(x => x.Write(21), Times.Once());
        }

        [Test]
        public void ShouldNot_ThrowException_WhenDivideByZero()
        {
            var mock = new Mock<IDistributor>();
            var calcEngine = new CalcEngine(new SimpleCalculator(), mock.Object);
            Assert.DoesNotThrow(() => calcEngine.Divide(5, 0));
        }

        [Test]
        public void Should_OutputDivisionByZeroWasPerformed_WhenDivideByZero()
        {
            var mock = new Mock<IDistributor>();
            var calcEngine = new CalcEngine(new SimpleCalculator(), mock.Object);
            calcEngine.Divide(7, 0);
            mock.Verify(x => x.Write(double.NaN), Times.Once());
        }
    }
}