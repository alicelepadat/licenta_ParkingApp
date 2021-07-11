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

        public async Task<Driver> GetByEmailAsync(string email)
        {
            return await _parkingMainContext.Drivers
                .Include(d => d.User)
                .Include(d => d.License)
                .SingleOrDefaultAsync(d => d.User.Email.ToLower() == email.ToLower());
        }

        public async Task<Driver> GetByIdAsync(int driverId, bool includeVehicles = false)
        {
            if (includeVehicles)
            {
                return await _parkingMainContext.Drivers
                    .Include(d=>d.User)
                    .Include(d=>d.License)
                    .Include(d => d.Vehicles)
                    .ThenInclude(v=>v.DriverReservations)
                    .SingleOrDefaultAsync(x => x.Id == driverId);
            }
            else
            {
                return await _parkingMainContext.Drivers
                    .Include(d=>d.User)
                    .Include(d=>d.License)
                    .SingleOrDefaultAsync(x => x.Id == driverId);
            }
        }
    }
}
