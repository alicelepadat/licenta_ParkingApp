using System.Collections.Generic;
using System.Threading.Tasks;
using ParkingApp.Main.DomainModels;

namespace ParkingApp.Main.DataAcces.Repository
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        Task<IEnumerable<Reservation>> GetDriverReservationsAsync(int driverId);
    }
}