using ParkingApp.Main.Dtos;
using System.Threading.Tasks;

namespace ParkingApp.Main.Services.Contracts
{
    public interface IVehicleService
    {
        Task<VehicleDto> GetByIdAsync(int vehicleId);

        Task<bool> VehicleExistsAsync(int driverId, string licensePlate);

        Task<VehicleDto> CreateAsync(int driverId, NewVehicleDto vehicle);

        Task DeleteAsync(int vehicleId);
    }
}
