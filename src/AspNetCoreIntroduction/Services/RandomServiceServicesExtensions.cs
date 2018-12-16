using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreIntroduction.Services
{
    public static class RandomServiceServicesExtensions
    {
        public static void AddRandomGenerator(this IServiceCollection services)
        {
            services.AddScoped(typeof(RandomGeneratorService));
            //services.AddSingleton(typeof(RandomGeneratorService));

            services.AddScoped(typeof(DefaultRandomService));
            //services.AddSingleton(typeof(DefaultRandomService));
        }
    }
}
