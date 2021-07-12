using Microsoft.EntityFrameworkCore;
using ParkingApp.Main.DomainModels;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ParkingApp.Main.DataAcces.Repository
{
    public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(ParkingMainContext parkingMainContext) : base(parkingMainContext)
        {

        }

        public async Task<Vehicle> GetWithReservationsAsync(int vehicleId, bool includeReservations = false)
        {
            if (includeReservations)
            {
                return await _parkingMainContext.Vehicles
                    .Include(v => v.DriverReservations)
                    .SingleOrDefaultAsync(v => v.Id == vehicleId);
            }
            else
            {
                return await _parkingMainContext.Vehicles
                    .SingleOrDefaultAsync(v => v.Id == vehicleId);
            }
        }
    }
}
