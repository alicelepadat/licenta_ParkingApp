using AutoMapper;
using ParkingApp.Main.DataAcces.UnitOfWork;
using ParkingApp.Main.DomainModels;
using ParkingApp.Main.Dtos;
using ParkingApp.Main.Services.Contracts;
using System;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

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

        public async Task<DriverDto> GetByUSerIdAsync(int userId, bool includeVehicles)
        {
            Driver model = await _unitOfWork.DriverRepository.GetByUserIdAsync(userId, includeVehicles);

            return _mapper.Map<Driver, DriverDto>(model);
        }

        public async Task UpdateLicenseAsync(int driverId, NewDrivingLicenseDto license)
        {
            var entity = await _unitOfWork.DriverRepository.GetByUserIdAsync(driverId);

            var date = DateTime.Parse(license.ExpirationDate, System.Globalization.CultureInfo.CurrentCulture);

            var model = _mapper.Map<NewDrivingLicenseDto, DrivingLicense>(license);

            model.ExpirationDate = date;

            await _unitOfWork.DrivingLicenseRepository.AddAsync(model);

            entity.License = model;

            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateDriverAsync(DriverDto driver)
        {
            var entity = await _unitOfWork.DriverRepository.GetByUserIdAsync(driver.Id);

            entity.User.Email = driver.User.Email;
            entity.User.Phone = driver.User.Phone;
            if (driver.User.Password.Length > 0)
            {
                entity.User.Password = BC.HashPassword(driver.User.Password);
            }
            entity.License.Number = driver.License.Number;
            entity.License.ExpirationDate = driver.License.ExpirationDate;

            await _unitOfWork.CommitAsync();
        }
    }
}
