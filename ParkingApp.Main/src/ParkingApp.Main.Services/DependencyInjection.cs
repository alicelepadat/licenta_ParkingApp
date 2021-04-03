using Microsoft.Extensions.DependencyInjection;
using ParkingApp.Main.Dtos.Mappers;
using ParkingApp.Main.Services.Contracts;

namespace ParkingApp.Main.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServicesConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(BaseProfile));

            services.AddTransient<IDriverService, DriverService>();
            services.AddTransient<IParkingAreaService, ParkingAreaService>();
            services.AddTransient<IReservationService, ReservationService>();
            services.AddTransient<IVehicleService, VehicleService>();

            return services;
        }
    }
}
