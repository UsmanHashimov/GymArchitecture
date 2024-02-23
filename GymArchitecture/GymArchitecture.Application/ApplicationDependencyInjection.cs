using GymArchitecture.Application.Services.GymService;
using Microsoft.Extensions.DependencyInjection;

namespace GymArchitecture.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IGymService, GymService>();
            return services;
        }
    }
}
