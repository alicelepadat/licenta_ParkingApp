using Microsoft.EntityFrameworkCore;
using ParkingApp.Main.DomainModels;
using System;
using System.Collections.Generic;
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

        public async Task<Driver> GetByIdWithVehiclesAsync(int driverId)
        {
            return await _parkingMainContext.Drivers
                .Include(d=>d.Vehicles)
                .SingleOrDefaultAsync(x => x.Id == driverId);
        }
    }
}
