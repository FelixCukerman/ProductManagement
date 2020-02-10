using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductManagement.DataAccess.DataAccept;
using System;

namespace ProductManagement.BusinessLogic.Configs
{
    public static class DataBaseContextConfig
    {
        public static void InjectDataBase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<ApplicationDbInitializer>();
        }
        public static void UseDataBase(this IApplicationBuilder app, IServiceProvider serviceProvider)
        {

            ApplicationDbContext applicationDbContext = serviceProvider.GetRequiredService<ApplicationDbContext>();
            applicationDbContext.Database.Migrate();

            ApplicationDbInitializer applicationDbInitializer = serviceProvider.GetRequiredService<ApplicationDbInitializer>();
            applicationDbInitializer.Initialize().Wait();
        }
    }
}
