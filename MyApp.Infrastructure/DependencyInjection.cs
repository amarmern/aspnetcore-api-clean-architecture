using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Core.Interfaces;
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
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CleanArchDB;Trusted_Connection=true;TrustServerCertificate=true;Encrypt=false;");
            });
            //Add dependency injection for the EmployeeRepository from the Core layer to the Infrastructure layer
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}
