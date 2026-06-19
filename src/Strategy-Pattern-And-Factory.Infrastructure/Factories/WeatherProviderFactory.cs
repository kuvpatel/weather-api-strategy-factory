using Strategy_Pattern_And_Factory.Domain.Enums;
using Strategy_Pattern_And_Factory.Infrastructure.Providers;
using Strategy_Pattern_And_Factory.Interfaces.Persistence;

namespace  Strategy_Pattern_And_Factory.Infrastructure.Factories
{
    public class WeatherProviderFactory : IWeatherProviderFactory
    {
        private readonly WeatherApiProvider _weatherApiProvider;
        private readonly OpenWeatherProvider _openWeatherProvider;

        public WeatherProviderFactory(WeatherApiProvider weatherApiProvider, OpenWeatherProvider openWeatherProvider)
        {
            _weatherApiProvider = weatherApiProvider;
            _openWeatherProvider = openWeatherProvider;
        }

        public IWeatherProvider GetProvider(WeatherProviderType providerType)
        {
            return providerType switch
            {
                WeatherProviderType.WeatherApi => _weatherApiProvider,
                WeatherProviderType.OpenWeather => _openWeatherProvider,
                _ => throw new NotSupportedException()
            };
        }
    }
}
