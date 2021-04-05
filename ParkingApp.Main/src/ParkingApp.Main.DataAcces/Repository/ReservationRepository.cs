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

        public async Task<Reservation> GetByIdAsync(int reservationId, bool includeParkingArea = false)
        {
            if (includeParkingArea)
            {
                return await _parkingMainContext.Reservations
                    .Include(r => r.ParkingArea)
                    .SingleOrDefaultAsync(r => r.Id == reservationId);
            }
            else {
                return await _parkingMainContext.Reservations
                   .SingleOrDefaultAsync(r => r.Id == reservationId);
            }
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
