using AutoMapper;
using ParkingApp.Main.DataAcces.UnitOfWork;
using ParkingApp.Main.DomainModels;
using ParkingApp.Main.Dtos;
using ParkingApp.Main.Services.Contracts;
using System;
using System.Threading.Tasks;

namespace ParkingApp.Main.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public VehicleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<VehicleDto> CreateAsync(int driverId, NewVehicleDto vehicle)
        {
            var model = _mapper.Map<NewVehicleDto, Vehicle>(vehicle);

            await _unitOfWork.VehicleRepository.AddAsync(model);

            await _unitOfWork.CommitAsync();

            return _mapper.Map<Vehicle, VehicleDto>(model);
        }

        public async Task DeleteAsync(int vehicleId)
        {
            var model = await _unitOfWork.VehicleRepository.GetWithReservationsAsync(vehicleId, true);

            if (model.DriverReservations.Count > 0)
            {
                foreach (var r in model.DriverReservations)
                {
                    if (r.VehicleId == vehicleId)
                    {
                        _unitOfWork.VehicleRepository.Remove(r.Vehicle);
                    }
                }
            }
            else
            {
                _unitOfWork.VehicleRepository.Remove(model);
            }

            await _unitOfWork.CommitAsync();
        }

        public async Task<VehicleDto> GetByIdAsync(int vehicleId)
        {
            var model = await _unitOfWork.VehicleRepository.GetWithReservationsAsync(vehicleId);

            return _mapper.Map<Vehicle, VehicleDto>(model);
        }

        public async Task<bool> VehicleExistsAsync(int driverId, string licensePlate)
        {
            var entity = await _unitOfWork.VehicleRepository
                .SingleOrDefaultAsync(v => v.DriverId == driverId && v.LicensePlate == licensePlate);

            return entity != null;
        }
    }
}
