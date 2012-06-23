using Moq;
using NUnit.Framework;
using BinaryAcademy.CalculatorEngine.Core;

namespace BinaryAcademy.CalculatorEngine.Tests
{
    [TestFixture]
    class CalcEngineTest
    {
        private CalcEngine calcEngine;
        private Mock<IDistributor> mock;

        [SetUp]
        public void SetUp()
        {
            mock = new Mock<IDistributor>();
            calcEngine = new CalcEngine(new SimpleCalculator(), mock.Object);
        }

        [Test]
        public void Should_Output7Once_WhenAdding3And4()
        {
            calcEngine.Add(3, 4);
            mock.Verify(x => x.Write((double)7), Times.Once());
        }

        [Test]
        public void Should_Output5Once_WhenSubtact4From9()
        {
            calcEngine.Subtract(9, 4);
            mock.Verify(x => x.Write((double)5), Times.Once());
        }

        [Test]
        public void Should_Output21Once_WhenMultiply7By3()
        {
            calcEngine.Multiple(7, 3);
            mock.Verify(x => x.Write((double)21), Times.Once());
        }

        [Test]
        public void ShouldNot_ThrowException_WhenDivideByZero()
        {
            Assert.DoesNotThrow(() => calcEngine.Divide(5, 0));
        }

        [Test]
        public void Should_OutputMessage_WhenDivideByZero()
        {
            calcEngine.Divide(5, 0);
            mock.Verify(x => x.Write(It.IsAny<string>()), Times.Once());
        }
    }
}