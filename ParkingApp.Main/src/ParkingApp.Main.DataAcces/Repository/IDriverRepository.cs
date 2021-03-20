using ParkingApp.Main.DomainModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkingApp.Main.DataAcces.Repository
{
    public interface IDriverRepository : IRepository<Driver>
    {
        Task<IEnumerable<Driver>> GetAllDriversAsync();

        Task<IEnumerable<Driver>> GetAllWithDrivingLicenseAsync();

        Task<IEnumerable<Driver>> GetAllWithVehiclesAsync();

        Task<Driver> GetByIdAsync(int driverId);

        Task<Driver> GetWithDrivingLicenseByIdAsync(int driverId);

        Task<Driver> GetWithVehiclesByIdAsync(int driverId);
    }
}
