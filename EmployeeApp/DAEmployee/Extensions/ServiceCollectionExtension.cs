using BL.Interfaces.UnitOfWork;
using Core.Factory;
using Core.Interfaces.DL;
using Core.Interfaces.DTO;
using Core.Interfaces.Factory;
using Core.Interfaces.Service;
using Core.Service;
using Data.Repositories;
using DL.Data;
using DL.DTO;
using DL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DL.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EmployeeDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CleanAPI"));
            });
        }

        public static void AddOptions(this IServiceCollection services, IConfiguration configuration)
        {
            //services.Configure<PaginationOptions>(configuration.GetSection("Pagination"));
            //services.Configure<PasswordOptions>(configuration.GetSection("PasswordOptions"));
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeClientService, EmployeeClientService>();
            services.AddTransient<IEmployeeFactory, EmployeeFactory>();
            services.AddTransient<IEmployeeClientRepository, EmployeeClientRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeDTO, EmployeeDTO>();
            services.AddTransient<IUnitOfWork, UnitOfWork.UnitOfWork>();
        }
    }
}
