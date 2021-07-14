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

        public async Task<AdminDto> GetAdminByUserIdAsync(int userId)
        {
            Admin model = await _unitOfWork.AdminRepository.GetByUserIdAsync(userId);

            return _mapper.Map<Admin, AdminDto>(model);
        }
    }
}