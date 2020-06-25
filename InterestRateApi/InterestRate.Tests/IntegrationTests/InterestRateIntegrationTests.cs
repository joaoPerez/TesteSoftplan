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
        public async Task Get_WhenCalled_ReturnTheInterestRate()
        {
           var response = await _client.GetAsync("/InterestRate/taxaJuros");


        }
    }
}
