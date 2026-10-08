using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MyApp.Core.Interfaces;
using MyApp.Core.Options;
using MyApp.Infrastructure.Data;
using MyApp.Infrastructure.Repositories;
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
            services.AddDbContext<AppDbContext>((provider, options) =>
            {
                // options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>().Value.DefaultConnection);
            });
            //Add dependency injection for the EmployeeRepository from the Core layer to the Infrastructure layer
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}
