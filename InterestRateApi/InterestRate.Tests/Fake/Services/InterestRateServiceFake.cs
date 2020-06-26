using InterestRate.Core.Interfaces.Services;

namespace InterestRate.Tests.Fake.Services
{
	public class InterestRateServiceFake : IInterestRateService
	{
		public float GetInterestRate()
		{
			return 0.01F;
		}
	}
}
