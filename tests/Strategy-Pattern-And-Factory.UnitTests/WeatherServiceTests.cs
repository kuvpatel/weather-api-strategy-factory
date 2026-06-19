using NSubstitute;
using Xunit;

namespace Strategy_Pattern_And_Factory.UnitTests
{
    using NSubstitute;
    using Strategy_Pattern_And_Factory.Domain.Enums;
    using Strategy_Pattern_And_Factory.DTOs;
    using Strategy_Pattern_And_Factory.Interfaces.Persistence;
    using Strategy_Pattern_And_Factory.Services;
    using Xunit;

    public class WeatherServiceTests
    {
        [Fact]
        public async Task GetWeatherAsync_WeatherApiProvider_CallsCorrectProvider()
        {
            // Arrange
            var factory = Substitute.For<IWeatherProviderFactory>();
            var provider = Substitute.For<IWeatherProvider>();

            var expected = new WeatherDTO()
            {
                Current = new CurrentDTO()
                {
                    TempC = 20,
                    Condition = new ConditionDTO()
                    {
                        Text = "Sunny In Londonx",
                        Icon = "//cdn.weatherapi.com/weather/64x64/day/113.png",
                        Code = 1000
                    }
                },
            };

            factory.GetProvider(WeatherProviderType.WeatherApi).Returns(provider);
            provider.GetWeatherAsync("London").Returns(expected);

            var service = new WeatherService(factory);

            // Act
            var result = await service.GetWeatherAsync("London", WeatherProviderType.WeatherApi);

            // Assert
            Assert.Equal(expected, result);

            factory.Received(1).GetProvider(WeatherProviderType.WeatherApi);

            await provider.Received(1).GetWeatherAsync("London");
        }

        [Fact]
        public async Task GetWeatherAsync_OpenWeatherProvider_CallsCorrectProvider()
        {
            // Arrange
            var factory = Substitute.For<IWeatherProviderFactory>();
            var provider = Substitute.For<IWeatherProvider>();

            var expected = new WeatherDTO()
            {
                Current = new CurrentDTO()
                {
                    TempC = 22,
                    Condition = new ConditionDTO()
                    {
                        Text = "Sunny In Paris",
                        Icon = "//cdn.weatherapi.com/weather/64x64/day/113.png",
                        Code = 1100
                    }
                },
            };

            factory.GetProvider(WeatherProviderType.OpenWeather).Returns(provider);
            provider.GetWeatherAsync("Paris").Returns(expected);

            var service = new WeatherService(factory);

            // Act
            var result = await service.GetWeatherAsync("Paris", WeatherProviderType.OpenWeather);

            // Assert
            Assert.Equal(expected, result);

            factory.Received(1).GetProvider(WeatherProviderType.OpenWeather);

            await provider.Received(1).GetWeatherAsync("Paris");
        }
    }
}
