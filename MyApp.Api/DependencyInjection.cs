using MyApp.Application;
using MyApp.Infrastructure;
using MyApp.Core;
namespace MyApp.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services , IConfiguration configuration)
        {
            // Register application services here
            // Example: services.AddTransient<IMyService, MyService>();
            services.AddApplicationDI()
                .AddInfrasttructureDI()
             .AddCoreDI(configuration);
            return services;
        }
    }
}
