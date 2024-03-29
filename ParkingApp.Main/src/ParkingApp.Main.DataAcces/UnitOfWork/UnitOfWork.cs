﻿using ParkingApp.Main.DataAcces.Repository;
using ParkingApp.Main.DomainModels;
using System;
using System.Threading.Tasks;

namespace ParkingApp.Main.DataAcces.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ParkingMainContext _parkingMainContext;
        private DriverRepository _driverRepository;
        private AdminRepository _adminRepository;
        private Repository<User> _userRepository;
        private Repository<DrivingLicense> _drivingLicenseRepository;
        private ParkingAreaRepository _parkingAreaRepository;
        private ReservationRepository _reservationRepository;
        private VehicleRepository _vehicleRepository;

        public UnitOfWork(ParkingMainContext parkingMainContext)
        {
            _parkingMainContext = parkingMainContext;
        }

        public IDriverRepository DriverRepository => _driverRepository ??= new DriverRepository(_parkingMainContext);
        
        public IAdminRepository AdminRepository => _adminRepository ??= new AdminRepository(_parkingMainContext);

        public IRepository<User> UserRepository => _userRepository ??= new Repository<User>(_parkingMainContext);

        public IRepository<DrivingLicense> DrivingLicenseRepository => _drivingLicenseRepository ??= new Repository<DrivingLicense>(_parkingMainContext);

        public IParkingAreaRepository ParkingAreaRepository => _parkingAreaRepository ??= new ParkingAreaRepository(_parkingMainContext);

        public IReservationRepository ReservationRepository => _reservationRepository ??= new ReservationRepository(_parkingMainContext);

        public IVehicleRepository VehicleRepository => _vehicleRepository ??= new VehicleRepository(_parkingMainContext);

        public async Task<int> CommitAsync()
        {
            return await _parkingMainContext.SaveChangesAsync(); 
        }

        public void Dispose() => _parkingMainContext.Dispose();
    }
}
