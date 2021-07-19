using Microsoft.EntityFrameworkCore;
using ParkingApp.Main.DomainModels;
using System.Threading.Tasks;

namespace ParkingApp.Main.DataAcces.Repository
{
    public class DriverRepository : Repository<Driver>, IDriverRepository
    {
        public DriverRepository(ParkingMainContext parkingMainContext) : base(parkingMainContext)
        {
        }
        
        public async Task<Driver> GetByUserIdAsync(int userId, bool includeVehicles = false)
        {
            if (includeVehicles)
            {
                return await _parkingMainContext.Drivers
                    .Include(d=>d.User)
                    .Include(d=>d.License)
                    .Include(d => d.Vehicles)
                    .SingleOrDefaultAsync(x => x.User.Id == userId);
            }
            else
            {
                return await _parkingMainContext.Drivers
                    .Include(d=>d.User)
                    .Include(d=>d.License)
                    .SingleOrDefaultAsync(x => x.User.Id == userId);
            }
        }
    }
}
