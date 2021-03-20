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

        public async Task<IEnumerable<Driver>> GetAllDriversAsync()
        {
            return await _parkingMainContext.Drivers
               .Include(d => d.User)
               .ToListAsync();
        }

        public async Task<IEnumerable<Driver>> GetAllWithDrivingLicenseAsync()
        {
            return await _parkingMainContext.Drivers
                .Include(d => d.User)
                .Include(d => d.License)
                .ThenInclude(l => l.Issuer)
                .ToListAsync();
        }

        public async Task<IEnumerable<Driver>> GetAllWithVehiclesAsync()
        {
            return await _parkingMainContext.Drivers
               .Include(d => d.User)
               .Include(d => d.Vehicles)
               .ToListAsync();
        }

        public async Task<Driver> GetByIdAsync(int driverId)
        {
            return await _parkingMainContext.Drivers
                .Include(d => d.User)
                .SingleOrDefaultAsync(d => d.Id == driverId);
        }

        public async Task<Driver> GetWithDrivingLicenseByIdAsync(int driverId)
        {
            return await _parkingMainContext.Drivers
                .Include(d => d.User)
                .Include(d => d.License)
                .ThenInclude(l => l.Issuer)
                .SingleOrDefaultAsync(d => d.Id == driverId);
        }

        public async Task<Driver> GetWithVehiclesByIdAsync(int driverId)
        {
            return await _parkingMainContext.Drivers
               .Include(d => d.User)
               .Include(d => d.Vehicles)
               .SingleOrDefaultAsync(d => d.Id == driverId);

        }
    }
}
