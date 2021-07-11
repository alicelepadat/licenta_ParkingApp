using ParkingApp.Main.Dtos;
using System.Threading.Tasks;

namespace ParkingApp.Main.Services.Contracts
{
    public interface IDriverService
    {
        Task<bool> DriverExistsAsync(string driverEmail);
        
        Task<DriverDto> GetByIdAsync(int driverId, bool includeVehicles = false);

        Task<DriverDto> CreateAsync(NewDriverDto driver);

        Task<DriverDto> AuthenticateAsync(AuthenticationRequestDto request);

        Task UpdateLicenseAsync(int driverId, NewDrivingLicenseDto license);

        Task UpdateDriverAsync(DriverDto driver);
    }
}
