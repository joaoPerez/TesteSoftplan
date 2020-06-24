using InterestRate.Core.Interfaces.Services;
using InterestRate.Tests.Fake.Services;
using NUnit.Framework;

namespace InterestRate.Tests.UnitTests.Services
{
    [TestFixture]
    public class InterestRateServiceTests
	{
        private IInterestRateService _interestRateService;
        
        [SetUp]
        public void Setup()
        {
            _interestRateService = new IInterestRateServiceFake();
        }

		[Test]
        public void GetInterestRate_WhenCalled_ReturnTheInterestRate()
        {
            float rate = _interestRateService.GetInterestRate();

            Assert.IsNotNull(rate);
        }

        [Test]
        public void GetInterestRate_WhenCalled_IsNotNegative()
        {
            float rate = _interestRateService.GetInterestRate();

            Assert.GreaterOrEqual(rate, 0);
        }
    }
}
