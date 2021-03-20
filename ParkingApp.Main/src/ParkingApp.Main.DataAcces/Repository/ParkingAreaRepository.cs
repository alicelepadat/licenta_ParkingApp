using Microsoft.EntityFrameworkCore;
using ParkingApp.Main.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkingApp.Main.DataAcces.Repository
{
    public class ParkingAreaRepository : Repository<ParkingArea>, IParkingAreaRepository
    {
        public ParkingAreaRepository(ParkingMainContext parkingMainContext) : base(parkingMainContext)
        {

        }
        public async Task<IEnumerable<ParkingArea>> GetAllAreasAsync()
        {
            return await _parkingMainContext.ParkingAreas
                .Include(a => a.Address)
                .ToListAsync();
        }
    }
}
