using InterestRate.Core.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using System;

namespace InterestRate.Services
{
	public class InterestRateService : IInterestRateService
	{
		private readonly IConfiguration _configuration;
		public InterestRateService(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public float GetInterestRate()
		{
			string interest = _configuration.GetSection("Interest").Value;

			return float.Parse(interest);
		}
	}
}
