using BinaryAcademy.CalculatorEngine.Core;
using Moq;
using NUnit.Framework;

namespace BinaryAcademy.CalculatorEngine.Tests
{
    [TestFixture]
    class DistributorTest
    {
        [Test]
        public void Should_Output5Once_WhenWriteCalled()
        {
            var mock = new Mock<IDistributor>();
            var distributor = mock.Object;
            distributor.Write(5);
            mock.Verify(x => x.Write(5), Times.Once());
        }
    }
}
