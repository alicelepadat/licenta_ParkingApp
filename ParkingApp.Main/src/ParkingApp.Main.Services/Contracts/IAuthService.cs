using System.Threading.Tasks;
using ParkingApp.Main.Common.Enums;
using ParkingApp.Main.Dtos;

namespace ParkingApp.Main.Services.Contracts
{
    public interface IAuthService
    {
        Task<UserDto> AuthenticateAsync(AuthenticationRequestDto request);
        
        Task<bool> UserExistsAsync(string email);
        
        Task<bool> GetUserByIdAsync(int userId);
        
        Task<UserRoleEnum> GetUserRoleAsync(int userId);
        
        Task<AdminDto> CreateAdminAsync(NewAdminDto admin);
        
        Task<DriverDto> CreateDriverAsync(NewDriverDto driver);
    }
}