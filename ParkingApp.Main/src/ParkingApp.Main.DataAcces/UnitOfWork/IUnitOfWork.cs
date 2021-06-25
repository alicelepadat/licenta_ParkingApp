using ParkingApp.Main.DataAcces.Repository;
using ParkingApp.Main.DomainModels;
using System;
using System.Threading.Tasks;

namespace ParkingApp.Main.DataAcces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> CommitAsync();
        IDriverRepository DriverRepository { get;  }
        IVehicleRepository VehicleRepository { get;  }
        IRepository<User> UserRepository { get; }
        IRepository<DrivingLicense> DrivingLicenseRepository { get; }
        
        IParkingAreaRepository ParkingAreaRepository { get; } 
        IReservationRepository ReservationRepository { get;  }
    }
}
