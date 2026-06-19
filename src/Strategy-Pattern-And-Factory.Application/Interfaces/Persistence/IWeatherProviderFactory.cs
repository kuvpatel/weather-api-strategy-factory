using Strategy_Pattern_And_Factory.Domain.Enums;

namespace Strategy_Pattern_And_Factory.Interfaces.Persistence
{
    public interface IWeatherProviderFactory
    {
        public IWeatherProvider GetProvider(WeatherProviderType providerType);

    }
}
