using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ParkingApp.Main.Common.Enums;
using ParkingApp.Main.DataAcces.Repository;
using ParkingApp.Main.DataAcces.UnitOfWork;
using ParkingApp.Main.DomainModels;
using ParkingApp.Main.Dtos;
using ParkingApp.Main.Services.Contracts;

namespace ParkingApp.Main.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ReservationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<IEnumerable<ReservationDto>> GetDriverReservationsAsync(int driverId)
        {
            var model = await _unitOfWork.ReservationRepository.GetDriverReservationsAsync(driverId);

            return _mapper.Map<IEnumerable<Reservation>, IEnumerable<ReservationDto>>(model);
        }

        public async Task<bool> ReservationExistsAsync(DateTime startTime, DateTime endTime, int parkingAreaId)
        {
            var reservationFound = await _unitOfWork.ReservationRepository
                .SingleOrDefaultAsync(r => 
                    r.ParkingAreaId == parkingAreaId && r.StartTime == startTime && r.EndTime == endTime);

            return reservationFound != null;
        }

        public async Task<int> CreateAsync(int driverId, int parkingAreaId, NewReservationDto reservation)
        {
            var model = _mapper.Map<NewReservationDto, Reservation>(reservation);
            model.ParkingAreaId = parkingAreaId;

            model.Vehicle.DriverId = driverId;
            
            model.StartTime = DateTime.Parse(reservation.StartTime, System.Globalization.CultureInfo.CurrentCulture);
            model.EndTime = DateTime.Parse(reservation.EndTime, System.Globalization.CultureInfo.CurrentCulture);
            model.State = ReservationStateEnum.REGISTERED;

            var area = await _unitOfWork.ParkingAreaRepository.GetByIdAsync(parkingAreaId);
            area.AvailableSpots -= 1;

            var vehicleExists = await _unitOfWork.VehicleRepository
                .SingleOrDefaultAsync(v => v.LicensePlate == model.Vehicle.LicensePlate);
            if (vehicleExists != null)
            {
                model = new Reservation
                {
                    ReservationDate = model.ReservationDate,
                    StartTime = model.StartTime,
                    EndTime = model.EndTime,
                    State = model.State,
                    ParkingAreaId = model.ParkingAreaId,
                    Vehicle = vehicleExists
                };
                await _unitOfWork.ReservationRepository.AddAsync(model);
            }
            else
            {
                await _unitOfWork.ReservationRepository.AddAsync(model);
            }

            await _unitOfWork.CommitAsync();

            return model.Id;
        }
    }
}