using ParkingApp.Main.DataAcces.Repository;
using ParkingApp.Main.DomainModels;
using System;
using System.Threading.Tasks;

namespace ParkingApp.Main.DataAcces.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ParkingMainContext _parkingMainContext;
        private DriverRepository _driverRepository;
        private Repository<User> _userRepository;
        private Repository<DrivingLicense> _drivingLicenseRepository;
        private Repository<Issuer> _issuerRepository;
        private ParkingAreaRepository _parkingAreaRepository;
        private ReservationRepository _reservationRepository;
        private Repository<Vehicle> _vehicleRepository;

        public UnitOfWork(ParkingMainContext parkingMainContext)
        {
            _parkingMainContext = parkingMainContext;
        }

        public IDriverRepository DriverRepository => _driverRepository ??= new DriverRepository(_parkingMainContext);

        public IRepository<User> UserRepository => _userRepository ??= new Repository<User>(_parkingMainContext);

        public IRepository<DrivingLicense> DrivingLicenseRepository => _drivingLicenseRepository ??= new Repository<DrivingLicense>(_parkingMainContext);

        public IRepository<Issuer> IssuerRepository => _issuerRepository ??= new Repository<Issuer>(_parkingMainContext);

        public IParkingAreaRepository ParkingAreaRepository => _parkingAreaRepository ??= new ParkingAreaRepository(_parkingMainContext);

        public IReservationRepository ReservationRepository => _reservationRepository ??= new ReservationRepository(_parkingMainContext);

        public IRepository<Vehicle> VehicleRepository => _vehicleRepository ??= new Repository<Vehicle>(_parkingMainContext);

        public async Task<int> CommitAsync()
        {
            return await _parkingMainContext.SaveChangesAsync(); 
        }

        public void Dispose() => _parkingMainContext.Dispose();
    }
}
