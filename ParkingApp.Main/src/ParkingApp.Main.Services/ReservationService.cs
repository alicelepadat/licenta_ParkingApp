using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ParkingApp.Main.Common.Enums;
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

        public async Task<IEnumerable<ReservationDto>> GetReservationsFromAreaAsync(int parkingAreaId)
        {
            var model = await _unitOfWork.ReservationRepository.GetReservationsFromAreaAsync(parkingAreaId);
            
            return _mapper.Map<IEnumerable<Reservation>, IEnumerable<ReservationDto>>(model);
        }

        public async Task<IEnumerable<ReservationDto>> GetDriverReservationsAsync(int driverId)
        {
            var model = await _unitOfWork.ReservationRepository.GetDriverReservationsAsync(driverId);

            return _mapper.Map<IEnumerable<Reservation>, IEnumerable<ReservationDto>>(model);
        }

        public async Task<IEnumerable<ReservationDto>> GetVehiclesReservationsAsync(string licensePlate)
        {
            var model = await _unitOfWork.ReservationRepository.GetVehicleReservationsAsync(licensePlate);

            return _mapper.Map<IEnumerable<Reservation>, IEnumerable<ReservationDto>>(model);
        }

        public async Task<bool> ReservationExistsAsync(DateTime date, DateTime startTime, DateTime endTime, int parkingAreaId)
        {
            var reservationFound = await _unitOfWork.ReservationRepository
                .SingleOrDefaultAsync(r => 
                    r.ParkingAreaId == parkingAreaId && r.ReservationDate.Date == date.Date && 
                    (startTime >= r.StartTime || startTime <= r.EndTime) && (endTime >= r.StartTime || endTime <= r.EndTime)
                    && (r.State == ReservationStateEnum.IN_PROGRESS));

            return reservationFound != null;
        }

        public async Task<ReservationDto> CreateAsync(int? driverId, int parkingAreaId, NewReservationDto reservation)
        {
            var model = _mapper.Map<NewReservationDto, Reservation>(reservation);

            model.ParkingAreaId = parkingAreaId;

            var area = await _unitOfWork.ParkingAreaRepository.GetByIdAsync(parkingAreaId);

            model.ParkingArea = area;
            model.Vehicle.DriverId = driverId;
            model.ReservationDate = DateTime.Parse(reservation.ReservationDate, System.Globalization.CultureInfo.CurrentCulture);
            model.StartTime = DateTime.Parse(reservation.StartTime, System.Globalization.CultureInfo.CurrentCulture);
            model.EndTime = DateTime.Parse(reservation.EndTime, System.Globalization.CultureInfo.CurrentCulture);
            model.State = ReservationStateEnum.ACTIVE;
            model.Price = CalculateReservationPrice(model);
           
            if (area.AvailableSpots > 0)
            {
                area.AvailableSpots -= 1;
            }

            var vehicleExists = await _unitOfWork.VehicleRepository.SingleOrDefaultAsync(v => v.LicensePlate == model.Vehicle.LicensePlate);
           
            if (vehicleExists != null)
            {
                model = new Reservation
                {
                    ReservationDate = model.ReservationDate,
                    StartTime = model.StartTime,
                    EndTime = model.EndTime,
                    State = model.State,
                    ParkingAreaId = model.ParkingAreaId,
                    Vehicle = vehicleExists,
                    Price = model.Price,
                };
                await _unitOfWork.ReservationRepository.AddAsync(model);
            }
            else
            {
                await _unitOfWork.ReservationRepository.AddAsync(model);
            }

            await _unitOfWork.CommitAsync();

            return _mapper.Map<Reservation, ReservationDto>(model);
        }

        public async Task DeleteAsync(int reservationId)
        {
            var model = await _unitOfWork.ReservationRepository.SingleOrDefaultAsync(r => r.Id == reservationId);

            _unitOfWork.ReservationRepository.Remove(model);

            await _unitOfWork.CommitAsync();
        }

        public async Task<ReservationDto> GetByIdAsync(int reservationId, bool includeParkingArea)
        {
            var model = await _unitOfWork.ReservationRepository.GetByIdAsync(reservationId, includeParkingArea);

            return _mapper.Map<Reservation, ReservationDto>(model);
        }

        public async Task UpdateReservationStateAsync(ReservationDto reservation)
        {
            var model = await _unitOfWork.ReservationRepository.SingleOrDefaultAsync(r => r.Id == reservation.Id);

            if (model.State == ReservationStateEnum.IN_PROGRESS && model.EndTime.TimeOfDay <= DateTime.Now.TimeOfDay)
            {
                model.State = ReservationStateEnum.FINISHED;
            }

            if (model.State == ReservationStateEnum.ACTIVE && model.ReservationDate.Date == DateTime.Now.Date)
            {
                if(model.StartTime.TimeOfDay <= DateTime.Now.TimeOfDay && model.EndTime.TimeOfDay >= DateTime.Now.TimeOfDay)
                {
                    model.State = ReservationStateEnum.IN_PROGRESS;
                }
            };

            await _unitOfWork.CommitAsync();
        }

        public async Task CancelReservationAsync(ReservationDto reservation)
        {
            var model = await _unitOfWork.ReservationRepository.SingleOrDefaultAsync(r => r.Id == reservation.Id);

            reservation.State = ReservationStateEnum.CANCELLED;

            model.State = reservation.State;

            await _unitOfWork.CommitAsync();
        }

        public static decimal CalculateReservationPrice(Reservation model)
        {
            TimeSpan reservationTime = model.EndTime - model.StartTime;

            var hours = reservationTime.Hours;
            if(reservationTime.Minutes > 0)
            {
                hours += 1;
            }

            var price = model.ParkingArea.PricePerHour * hours;

            return price;
        }

        public async Task<IEnumerable<ReservationDto>> GetParkingAreaReservationsAsync(int areaId)
        {
            var model = await _unitOfWork.ReservationRepository.GetParkingAreaReservationsAsync(areaId);

            return _mapper.Map<IEnumerable<Reservation>, IEnumerable<ReservationDto>>(model);
        }

        public async Task<IEnumerable<ReservationDto>> GetReservationsAsync()
        {
            var model = await _unitOfWork.ReservationRepository.GetReservationsAsync();

            return _mapper.Map<IEnumerable<Reservation>, IEnumerable<ReservationDto>>(model);
        }

        public async Task UpdateReservationPaymentAsync(int reservationId)
        {
            var entity = await _unitOfWork.ReservationRepository.GetByIdAsync(reservationId);

            entity.IsPaid = true;

            await _unitOfWork.CommitAsync();
        }
    }
}