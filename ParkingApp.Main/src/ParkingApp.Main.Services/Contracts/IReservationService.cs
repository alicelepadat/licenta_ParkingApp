using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ParkingApp.Main.Dtos;

namespace ParkingApp.Main.Services.Contracts
{
    public interface IReservationService
    {
        Task<IEnumerable<ReservationDto>> GetReservationsAsync();

        Task<IEnumerable<ReservationDto>> GetReservationsFromAreaAsync(int parkingAreaId);

        Task<IEnumerable<ReservationDto>> GetDriverReservationsAsync(int driverId);

        Task<IEnumerable<ReservationDto>> GetVehiclesReservationsAsync(string licensePlate);

        Task<IEnumerable<ReservationDto>> GetParkingAreaReservationsAsync(int areaId);

        Task<ReservationDto> GetByIdAsync(int reservattionId, bool includeParkingArea = false);
        
        Task<bool> ReservationExistsAsync(DateTime date, DateTime startTime, DateTime endTime, int parkingAreaId);

        Task<ReservationDto> CreateAsync(int? driverId,int parkingAreaId , NewReservationDto reservation);

        Task UpdateReservationStateAsync(ReservationDto reservation);

        Task CancelReservationAsync(ReservationDto reservation);

        Task DeleteAsync(int reservationId);
    }
}