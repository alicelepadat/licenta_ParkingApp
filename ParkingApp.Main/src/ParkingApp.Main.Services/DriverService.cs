using AutoMapper;
using ParkingApp.Main.DataAcces.UnitOfWork;
using ParkingApp.Main.DomainModels;
using ParkingApp.Main.Dtos;
using ParkingApp.Main.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParkingApp.Main.Services
{
    public class DriverService : IDriverService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DriverService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<DriverDto> CreateAsync(NewDriverDto driver)
        {
            var model = _mapper.Map<NewDriverDto, Driver>(driver);

            await _unitOfWork.DriverRepository.AddAsync(model);

            await _unitOfWork.CommitAsync();

            return _mapper.Map<Driver, DriverDto>(model);
        }

        public async Task DeleteAsync(int driverId)
        {
            var modelToBeDeleted = await _unitOfWork.DriverRepository.GetWithDrivingLicenseByIdAsync(driverId);

            //modelToBeDeleted.Vehicles.ForEach(vehicle =>
            //{
            //    _unitOfWork.ReservationRepository.Remove(vehicle.DriverReservation);
            //    _unitOfWork.VehicleRepository.Remove(vehicle);
            //});

            _unitOfWork.IssuerRepository.Remove(modelToBeDeleted.License.Issuer);
            _unitOfWork.DrivingLicenseRepository.Remove(modelToBeDeleted.License);
            _unitOfWork.UserRepository.Remove(modelToBeDeleted.User);

            _unitOfWork.DriverRepository.Remove(modelToBeDeleted);

            await _unitOfWork.CommitAsync();

        }

        public async Task<bool> DriverExistsAsync(string driverName)
        {
            var driverFound = await _unitOfWork.DriverRepository.SingleOrDefaultAsync(x => x.User.Name.ToLower() == driverName.ToLower());

            return driverFound != null;
        }

        public async Task<IEnumerable<DriverDto>> GetAllAsync(bool includeDrivingLicense = false, bool includeVehicles = false)
        {
            IEnumerable<Driver> models;

            if (includeDrivingLicense)
                models = await _unitOfWork.DriverRepository.GetAllWithDrivingLicenseAsync();
            else if (includeVehicles)
                models = await _unitOfWork.DriverRepository.GetAllWithVehiclesAsync();
            else
                models = await _unitOfWork.DriverRepository.GetAllDriversAsync();

            return _mapper.Map<IEnumerable<Driver>, IEnumerable<DriverDto>>(models);
        }

        public async Task<DriverDto> GetByIdAsync(int driverId)
        {
            Driver model = await _unitOfWork.DriverRepository.GetWithDrivingLicenseByIdAsync(driverId);

            return _mapper.Map<Driver, DriverDto>(model);
        }

        public async Task<DriverDto> GetWithVehiclesByIdAsync(int driverId, bool includeVehicles = false)
        {
            Driver model;

            if (includeVehicles)
                model = await _unitOfWork.DriverRepository.GetWithVehiclesByIdAsync(driverId);
            else
                model = await _unitOfWork.DriverRepository.GetByIdAsync(driverId);

            return _mapper.Map<Driver, DriverDto>(model);
        }

        public async Task UpdateAsync(DriverDto driver)
        {
            var entity = await _unitOfWork.DriverRepository.SingleOrDefaultAsync(x => x.Id == driver.Id);

            entity.User.Name = driver.User.Name;
            entity.User.Phone = driver.User.Phone;
            entity.User.Password = driver.User.Password;

            await _unitOfWork.CommitAsync();
        }
    }
}
