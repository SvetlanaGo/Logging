using NUnit.Framework;
using Moq;

namespace Logging.Tests
{
    public class Tests
    {
        private Mock<IAlgorithm> mock;

        [OneTimeSetUp]
        public void SetUp()
        {
            mock = new Mock<IAlgorithm>();
        }

        [Test]
        public void CalculateOnceTime_Sum()
        {
            mock.Setup(provider => provider.Calculate(1, 2))
                .Returns(() => new CalculateSum().Calculate(1, 2));

            IAlgorithm algorithm = mock.Object;

            var actualValue = algorithm.Calculate(1, 2);

            Assert.AreEqual(3, actualValue);

            mock.Verify(provider => provider.Calculate(1, 2), Times.Exactly(2));
        }

        [Test]
        public void CalculateOnceTime_Difference()
        {
            mock.Setup(provider => provider.Calculate(1, 2))
                .Returns(() => new CalculateDifference().Calculate(1, 2));

            IAlgorithm algorithm = mock.Object;

            var actualValue = algorithm.Calculate(1, 2);

            Assert.AreEqual(-1, actualValue);

            mock.Verify(provider => provider.Calculate(1, 2), Times.Once);
        }
    }
}