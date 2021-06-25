using ParkingApp.Main.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkingApp.Main.DataAcces.Repository
{
    public interface IParkingAreaRepository : IRepository<ParkingArea>
    {
        Task<ParkingArea> GetByIdAsync(int id);

        Task<IEnumerable<ParkingArea>> GetAllAreasAsync();
    }
}
