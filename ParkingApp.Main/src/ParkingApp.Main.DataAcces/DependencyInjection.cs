using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ParkingApp.Main.DataAcces.UnitOfWork;

namespace ParkingApp.Main.DataAcces
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccessConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ParkingMainContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IUnitOfWork, UnitOfWork.UnitOfWork>();

            return services;
        }
    }
}
