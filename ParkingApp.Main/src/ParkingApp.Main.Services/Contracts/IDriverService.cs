using ParkingApp.Main.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkingApp.Main.Services.Contracts
{
    public interface IDriverService
    {
        Task<IEnumerable<DriverDto>> GetAllAsync(bool includeDrivingLicense = false, bool includeVehicles = false);

        Task<DriverDto> GetByIdAsync(int driverId);

        Task<DriverDto> GetWithVehiclesByIdAsync(int driverId, bool includeVehicles = false);

        Task<bool> DriverExistsAsync(string driverName);

        Task<DriverDto> CreateAsync(NewDriverDto driver);

        Task UpdateAsync(DriverDto driver);

        Task DeleteAsync(int driverId);
    }
}
