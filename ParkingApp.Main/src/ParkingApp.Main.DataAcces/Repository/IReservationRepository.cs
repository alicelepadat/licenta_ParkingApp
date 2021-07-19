using System.Collections.Generic;
using System.Threading.Tasks;
using ParkingApp.Main.DomainModels;

namespace ParkingApp.Main.DataAcces.Repository
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        Task<IEnumerable<Reservation>> GetReservationsAsync();

        Task<IEnumerable<Reservation>> GetDriverReservationsAsync(int driverId);
        
        Task<IEnumerable<Reservation>> GetReservationsFromAreaAsync(int parkinAreaId);

        Task<IEnumerable<Reservation>> GetVehicleReservationsAsync(string licensePlate);

        Task<IEnumerable<Reservation>> GetParkingAreaReservationsAsync(int areaId);

        Task<Reservation> GetByIdAsync(int reservationId, bool includeParkingArea = false);

    }
}