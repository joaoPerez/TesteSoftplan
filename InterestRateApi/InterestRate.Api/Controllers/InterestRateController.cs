using System.Collections.Generic;
using InterestRate.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace InterestRate.Api.Controllers
{
    [ApiController]
    public class InterestRateController : ControllerBase
    {
        private readonly IInterestRateService _interestRateService;
        public InterestRateController(IInterestRateService interestRateService)
        {
            _interestRateService = interestRateService;
        }

        // GET: api/InterestRate
        [HttpGet]
        [Route("taxaJuros")]
        public float Get()
        {
            return _interestRateService.GetInterestRate();
        }
    }
}
