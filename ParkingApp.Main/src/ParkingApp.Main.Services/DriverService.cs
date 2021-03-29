using AutoMapper;
using ParkingApp.Main.DataAcces.UnitOfWork;
using ParkingApp.Main.DomainModels;
using ParkingApp.Main.Dtos;
using ParkingApp.Main.Services.Contracts;
using System;
using System.Collections.Generic;
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
            var account = await _unitOfWork.DriverRepository.GetDriverAsync(request.Email);

            if (account == null || !BC.Verify(request.Password, account.User.Password))
            {
                throw new UnauthorizedAccessException("Email-ul sau parola sunt incorecte.");
            }

            return _mapper.Map<Driver, DriverDto>(account);
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
            var driverFound = await _unitOfWork.DriverRepository.GetDriverAsync(driverEmail);

            return driverFound != null;
        }

    }
}
