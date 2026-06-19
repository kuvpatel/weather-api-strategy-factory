using Strategy_Pattern_And_Factory.Domain.Enums;
using Strategy_Pattern_And_Factory.DTOs;
using Strategy_Pattern_And_Factory.Interfaces.Persistence;

namespace  Strategy_Pattern_And_Factory.Services
{
    public class WeatherService
    {
        private readonly IWeatherProviderFactory _factory;

        public WeatherService(IWeatherProviderFactory factory)
        {
            _factory = factory;
        }

        public async Task<WeatherDTO> GetWeatherAsync(string location, WeatherProviderType providerType)
        {
            var provider = _factory.GetProvider(providerType);

            return await provider.GetWeatherAsync(location);
        }
    }
}
