using Microsoft.EntityFrameworkCore;
using ParkingApp.Main.DomainModels;
using System.Collections.Generic;
using System.Linq;
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
                .ThenInclude(a=>a.Coordinates)
                .Include(a=>a.Company)
                .ToListAsync();
        }

        public async Task<ParkingArea> GetByIdAsync(int id, bool includeAddress = false)
        {
            if (includeAddress)
            {
                return await _parkingMainContext.ParkingAreas.Include(a => a.Address).SingleOrDefaultAsync(a => a.Id == id);
            }

            return await _parkingMainContext.ParkingAreas.SingleOrDefaultAsync(a => a.Id == id);
        }
    }
}
