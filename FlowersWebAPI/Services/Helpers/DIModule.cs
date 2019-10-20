using DataAccess;
using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Helpers
{
    public class DIModule
    {
        public static IServiceCollection RegisterModule(
            IServiceCollection services, string connectionString)
        {
            services.AddTransient<IRepository<FlowerDto>, FlowerRepository>();
            services.AddTransient<IRepository<OrderDto>, OrderRepository>();
            services.AddDbContext<AppDbContext>(x =>
            x.UseSqlServer(connectionString));

            return services;
        }
    }
}
