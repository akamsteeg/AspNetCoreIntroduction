using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreIntroduction.Services
{
    public static class RandomServiceServicesExtensions
    {
        public static void AddRandomGenerator(this IServiceCollection services)
        {
            services.AddTransient(typeof(RandomGeneratorService));

            services.AddScoped(typeof(DefaultRandomService));
        }
    }
}
