using ParkingApp.Main.Dtos;
using System.Threading.Tasks;

namespace ParkingApp.Main.Services.Contracts
{
    public interface IDriverService
    {
        Task<DriverDto> GetByUSerIdAsync(int userId, bool includeVehicles = false);

        Task UpdateLicenseAsync(int driverId, NewDrivingLicenseDto license);

        Task UpdateDriverAsync(DriverDto driver);
    }
}
