using Strategy_Pattern_And_Factory.DTOs;

namespace Strategy_Pattern_And_Factory.Interfaces.Persistence
{
    public interface IWeatherProvider
    {
        public Task<WeatherDTO> GetWeatherAsync(string location);
    }
}
