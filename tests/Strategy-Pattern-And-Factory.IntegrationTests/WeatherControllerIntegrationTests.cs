
namespace Strategy_Pattern_And_Factory.IntegrationTests
{
    using Strategy_Pattern_And_Factory.Domain.Enums;
    using Strategy_Pattern_And_Factory.DTOs;
    using System.Net;
    using System.Text.Json;
    using Xunit;

    public class WeatherControllerIntegrationTests
    {
        private readonly HttpClient _client;

        public WeatherControllerIntegrationTests()
        {
            var factory = new WeatherApiFactory();
            _client = factory.CreateClient();
        }

        [Theory]
        [InlineData("London", WeatherProviderType.WeatherApi)]
        [InlineData("Paris", WeatherProviderType.OpenWeather)]
        public async Task GetWeather_Returns200_ForValidRequest(string location, WeatherProviderType providerType)
        {
            // Arrange
            var url = $"/api/weather?location={location}&provider={providerType}";

            // Act
            var response = await _client.GetAsync(url);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var json = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<WeatherDTO>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            Assert.NotNull(result);
        }
    }
}
