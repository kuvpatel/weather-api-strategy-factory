using Strategy_Pattern_And_Factory.DTOs;
using Strategy_Pattern_And_Factory.Interfaces.Persistence;

namespace Strategy_Pattern_And_Factory.Infrastructure.Providers
{
    public class OpenWeatherProvider : IWeatherProvider
    {
        public async Task<WeatherDTO> GetWeatherAsync(string location)
        {
            var weather = new WeatherDTO()
            {
                Current = new CurrentDTO()
                {
                    TempC = 20,
                    Condition = new ConditionDTO()
                    {
                        Text = "Sunny",
                        Icon = "//cdn.weatherapi.com/weather/64x64/day/113.png",
                        Code = 1100
                    }
                },
            };

            return weather;
        }
    }
}
