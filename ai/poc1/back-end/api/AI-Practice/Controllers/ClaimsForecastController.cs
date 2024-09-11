using AI_Practice.Models;
using AI_Practice.Services;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace AI_Practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClaimsForecastController : ControllerBase
    {
       
        private readonly ILogger<ClaimsForecastController> _logger;
        private readonly IClaimsForecastService claimsForecastService;

        public ClaimsForecastController(ILogger<ClaimsForecastController> logger,IClaimsForecastService claimsForecastService)
        {
            _logger = logger;
            this.claimsForecastService = claimsForecastService;
        }

        [HttpPost]
        public IActionResult Predict([FromBody] WeatherInput input)
        {
            var prediction = claimsForecastService.Predict(input);
            return Ok(prediction);
        }
    }
}
