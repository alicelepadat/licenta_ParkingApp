using ParkingApp.Main.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkingApp.Main.DataAcces.Repository
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        Task<Vehicle> GetWithReservationsAsync(int vehicleId, bool inlcudeReservations = false);
    }
}
