using ParkingApp.Main.DomainModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkingApp.Main.DataAcces.Repository
{
    public interface IDriverRepository : IRepository<Driver>
    {
        Task<Driver> GetByUserIdAsync(int userId, bool includeVehicles = false);
    }
}
