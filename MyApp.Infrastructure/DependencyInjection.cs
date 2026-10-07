using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrasttructureDI(this IServiceCollection services)
        {
            // Register application services here
            // Example: services.AddTransient<IMyService, MyService>();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CleanArchDB;Trusted_Connection=true;TrustServerCertificate=true;Encrypt=false;");
            });
            return services;
        }
    }
}
