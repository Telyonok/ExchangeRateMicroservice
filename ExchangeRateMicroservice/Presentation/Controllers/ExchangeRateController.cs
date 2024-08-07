using ExchangeRateMicroservice.Application.Services.RateService;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeRateMicroservice.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ExchangeRateController : ControllerBase
    {
        public readonly IRateService _rateService;
        public ExchangeRateController(IRateService rateService)
        {
            _rateService = rateService;
        }
    }
}
