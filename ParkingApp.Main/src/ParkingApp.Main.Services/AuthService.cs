using System;
using System.Threading.Tasks;
using AutoMapper;
using ParkingApp.Main.Common.Enums;
using ParkingApp.Main.DataAcces.UnitOfWork;
using ParkingApp.Main.DomainModels;
using ParkingApp.Main.Dtos;
using ParkingApp.Main.Services.Contracts;
using BC = BCrypt.Net.BCrypt;

namespace ParkingApp.Main.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AuthService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        
        public async Task<UserDto> AuthenticateAsync(AuthenticationRequestDto request)
        {
            var account = await _unitOfWork.UserRepository.SingleOrDefaultAsync(u => u.Email == request.Email);

            if (account == null || !BC.Verify(request.Password, account.Password))
            {
                return null;
            }

            return _mapper.Map<User, UserDto>(account);
        }
        
        public async Task<bool> UserExistsAsync(string email)
        {
            var userFound = await _unitOfWork.UserRepository.SingleOrDefaultAsync(u => u.Email == email);

            return userFound != null;
        }

        public async Task<UserDto> GetUserByIdAsync(int userId)
        {
            var userFound = await _unitOfWork.UserRepository.SingleOrDefaultAsync(u => u.Id == userId);

            return _mapper.Map<User, UserDto>(userFound);
        }

        public async Task<UserRoleEnum> GetUserRoleAsync(int userId)
        {
            var model = await _unitOfWork.UserRepository.SingleOrDefaultAsync(u => u.Id == userId);

            return model.Role;
        }

        public async Task<AdminDto> CreateAdminAsync(NewAdminDto admin)
        {
            var model = _mapper.Map<NewAdminDto, Admin>(admin);

            model.User.Role = UserRoleEnum.ADMIN;

            model.User.Password = BC.HashPassword(admin.User.Password);
            
            await _unitOfWork.AdminRepository.AddAsync(model);

            await _unitOfWork.CommitAsync();

            return _mapper.Map<Admin, AdminDto>(model);
        }

        public async Task<DriverDto> CreateDriverAsync(NewDriverDto driver)
        {
            var model = _mapper.Map<NewDriverDto, Driver>(driver);

            model.User.Password = BC.HashPassword(driver.User.Password);
            
            await _unitOfWork.DriverRepository.AddAsync(model);

            await _unitOfWork.CommitAsync();

            return _mapper.Map<Driver, DriverDto>(model);
        }

        public async Task UpdateUserAsync(UserDto user)
        {
            var entity = await _unitOfWork.UserRepository.SingleOrDefaultAsync(u => u.Id == user.Id);

            if (user.Password.Length > 0)
            {
                entity.Password = BC.HashPassword(user.Password);
            }

            await _unitOfWork.CommitAsync();
        }
    }
}