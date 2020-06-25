using InterestRate.Api;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InterestRate.Tests.IntegrationTests
{
	[TestFixture]
	class InterestRateIntegrationTests
	{
		private HttpClient _client;

		[SetUp]
		public void Setup()
		{
			WebApplicationFactory<Startup> webAppFactory = new WebApplicationFactory<Startup>();
			_client = webAppFactory.CreateClient();
		}

		[Test]
		public async Task Get_WhenCalled_ReturnStatusOK()
		{
			var response = await _client.GetAsync("/taxaJuros");
			response.EnsureSuccessStatusCode();
		}

		[Test]
		public async Task Get_WhenCalled_IsNotNegative()
		{
			var response = await _client.GetAsync("/taxaJuros");
			string value = await response.Content.ReadAsStringAsync();

			Assert.GreaterOrEqual(float.Parse(value), 0);
		}

		[Test]
		public async Task Get_WhenCalled_ReturnsFloat()
		{
			var response = await _client.GetAsync("/taxaJuros");
			string value = await response.Content.ReadAsStringAsync();

			Assert.IsTrue(float.TryParse(value, out _));
		}
	}
}
