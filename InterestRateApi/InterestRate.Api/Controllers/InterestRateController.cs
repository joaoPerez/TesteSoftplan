using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace InterestRate.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InterestRateController : ControllerBase
    {
        // GET: api/InterestRate
        [HttpGet]
        [Route("taxaJuros")]
        public decimal Get()
        {
            return 0;
        }
    }
}
