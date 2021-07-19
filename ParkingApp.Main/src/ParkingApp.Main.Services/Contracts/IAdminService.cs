using System.Threading.Tasks;
using ParkingApp.Main.Dtos;

namespace ParkingApp.Main.Services.Contracts
{
    public interface IAdminService
    {

        Task<AdminDto> GetAdminByUserIdAsync(int userId);
        
    }
}