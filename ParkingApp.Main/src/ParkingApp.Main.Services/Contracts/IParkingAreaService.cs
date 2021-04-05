using ParkingApp.Main.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkingApp.Main.Services.Contracts
{
    public interface IParkingAreaService
    {
        Task<IEnumerable<ParkingAreaDto>> GetAllAreasAsync();

        Task UpdateAvailableSpotsAsync(ParkingAreaDto parkingArea);

    }
}
