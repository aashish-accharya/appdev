using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week19.application.Common.Interface;
using week19.infrastructure.Persistance;
using week19.infrastructure.Services;

namespace week19.infrastructure.DI;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) {
        services.AddDbContext<ApplicationDBContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("Week19PostgresSQL"),
            b =>
            b.MigrationsAssembly(typeof(ApplicationDBContext).Assembly.FullName)),ServiceLifetime.Transient);

        services.AddScoped<IApplicationDBContext>(provider => provider.GetService<ApplicationDBContext>());
        services.AddTransient<IDateTime, DateTimeService>();
        services.AddScoped<IEmployeeDetails, EmployeeService>();
        services.AddTransient<IAuthentication,AuthenticationService>();

        return services;
    }
}
