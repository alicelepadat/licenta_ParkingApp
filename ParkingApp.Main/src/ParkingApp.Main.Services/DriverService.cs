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

        public async Task<DriverDto> AuthenticateAsync(AuthenticationRequestDto request)
        {
            var account = await _unitOfWork.DriverRepository.GetByEmailAsync(request.Email);

            if (account == null || !BC.Verify(request.Password, account.User.Password))
            {
                return null;
            }

            return _mapper.Map<Driver, DriverDto>(account);
        }

        public async Task<DriverDto> GetByIdAsync(int driverId, bool includeVehicles)
        {
            Driver model;

            model = await _unitOfWork.DriverRepository.GetByIdAsync(driverId, includeVehicles);
            
            return _mapper.Map<Driver, DriverDto>(model);
        }

        public async Task<DriverDto> CreateAsync(NewDriverDto driver)
        {
            var model = _mapper.Map<NewDriverDto, Driver>(driver);

            model.User.Password = BC.HashPassword(driver.User.Password);
            
            await _unitOfWork.DriverRepository.AddAsync(model);

            await _unitOfWork.CommitAsync();

            return _mapper.Map<Driver, DriverDto>(model);
        }

        public async Task<bool> DriverExistsAsync(string driverEmail)
        {
            var driverFound = await _unitOfWork.DriverRepository.GetByEmailAsync(driverEmail);

            return driverFound != null;
        }

        public async Task UpdateLicenseAsync(int driverId, NewDrivingLicenseDto license)
        {
            var entity = await _unitOfWork.DriverRepository.GetByIdAsync(driverId);

            var date = DateTime.Parse(license.ExpirationDate, System.Globalization.CultureInfo.CurrentCulture);

            var model = _mapper.Map<NewDrivingLicenseDto, DrivingLicense>(license);

            model.ExpirationDate = date;

            await _unitOfWork.DrivingLicenseRepository.AddAsync(model);

            entity.License = model;

            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateDriverAsync(DriverDto driver)
        {
            var entity = await _unitOfWork.DriverRepository.GetByIdAsync(driver.Id);

            entity.User.Email = driver.User.Email;
            entity.User.Phone = driver.User.Phone;
            entity.User.Password = BC.HashPassword(driver.User.Password);
            entity.License.Number = driver.License.Number;
            entity.License.ExpirationDate = driver.License.ExpirationDate;

            await _unitOfWork.CommitAsync();
        }
    }
}
