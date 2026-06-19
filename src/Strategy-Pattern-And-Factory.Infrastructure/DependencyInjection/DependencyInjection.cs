using Microsoft.Extensions.DependencyInjection;
using Strategy_Pattern_And_Factory.Infrastructure.Factories;
using Strategy_Pattern_And_Factory.Infrastructure.Providers;
using Strategy_Pattern_And_Factory.Interfaces.Persistence;


namespace Strategy_Pattern_And_Factory.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IWeatherProviderFactory, WeatherProviderFactory>();
            services.AddScoped<WeatherApiProvider>();
            services.AddScoped<OpenWeatherProvider>();

            return services;
        }
    }
}
