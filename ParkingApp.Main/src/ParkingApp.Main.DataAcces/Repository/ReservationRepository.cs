using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParkingApp.Main.DomainModels;

namespace ParkingApp.Main.DataAcces.Repository
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRepository(ParkingMainContext parkingMainContext) : base(parkingMainContext)
        {
        }

        public async Task<IEnumerable<Reservation>> GetDriverReservationsAsync(int driverId)
        {
            return await _parkingMainContext.Reservations
                .Include(r=>r.ParkingArea)
                .ThenInclude(a=>a.Address)
                .Include(r => r.Vehicle)
                .Where(v=>v.Vehicle.DriverId == driverId)
                .ToListAsync();
        }
    }
}
