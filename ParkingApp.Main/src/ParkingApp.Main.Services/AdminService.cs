using System;
using System.Threading.Tasks;
using AutoMapper;
using ParkingApp.Main.DataAcces.UnitOfWork;
using ParkingApp.Main.Dtos;
using ParkingApp.Main.DomainModels;
using ParkingApp.Main.Services.Contracts;

namespace ParkingApp.Main.Services
{
    public class AdminService : IAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AdminService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task DeleteAdminAccountAsync(int adminId)
        {
            var admin = await _unitOfWork.AdminRepository.SingleOrDefaultAsync(a => a.Id == adminId);

            var user = await _unitOfWork.UserRepository.SingleOrDefaultAsync(u => u.Id == admin.UserId);

            _unitOfWork.UserRepository.Remove(user);
            _unitOfWork.AdminRepository.Remove(admin);

            await _unitOfWork.CommitAsync();
        }

        public async Task<AdminDto> GetAdminByUserIdAsync(int userId)
        {
            var model = await _unitOfWork.AdminRepository.GetByUserIdAsync(userId);

            return _mapper.Map<Admin, AdminDto>(model);
        }
    }
}