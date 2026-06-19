using Microsoft.AspNetCore.Mvc;
using Strategy_Pattern_And_Factory.Domain.Enums;
using Strategy_Pattern_And_Factory.Services;

namespace Strategy_Pattern_And_Factory_Api.Controllers
{
    [ApiController]
    [Route("api/weather")]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherService _weatherService;

        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string location, WeatherProviderType provider)
        {
            var result = await _weatherService.GetWeatherAsync(location, provider);

            return Ok(result);
        }
    }
}
