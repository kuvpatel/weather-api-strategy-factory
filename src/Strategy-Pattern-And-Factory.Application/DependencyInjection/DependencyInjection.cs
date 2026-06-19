using Microsoft.Extensions.DependencyInjection;
using Strategy_Pattern_And_Factory.Services;

namespace Strategy_Pattern_And_Factory.Application.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            
            services.AddScoped<WeatherService>();

            return services;
        }
    }
}
