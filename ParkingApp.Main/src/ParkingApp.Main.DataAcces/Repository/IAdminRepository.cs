using ParkingApp.Main.DomainModels;
using System.Threading.Tasks;

namespace ParkingApp.Main.DataAcces.Repository
{
    public interface IAdminRepository : IRepository<Admin>
    {
        Task<Admin> GetByUserIdAsync(int userId);
    }
}