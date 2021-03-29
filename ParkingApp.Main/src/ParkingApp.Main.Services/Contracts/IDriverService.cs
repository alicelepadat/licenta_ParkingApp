using ParkingApp.Main.Dtos;
using System.Threading.Tasks;

namespace ParkingApp.Main.Services.Contracts
{
    public interface IDriverService
    {
        Task<bool> DriverExistsAsync(string driverEmail);

        Task<DriverDto> CreateAsync(NewDriverDto driver);

        Task<DriverDto> AuthenticateAsync(AuthenticationRequestDto request);
    }
}
