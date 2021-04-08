using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ParkingApp.Main.Common.Enums;
using ParkingApp.Main.DomainModels;
using ParkingApp.Main.Dtos;

namespace ParkingApp.Main.Services.Contracts
{
    public interface IReservationService
    {
        Task<IEnumerable<ReservationDto>> GetReservationsFromAreaAsync(int parkingAreaId);
        
        Task<IEnumerable<ReservationDto>> GetDriverReservationsAsync(int driverId);

        Task<ReservationDto> GetByIdAsync(int reservattionId, bool includeParkingArea = false);
        
        Task<bool> ReservationExistsAsync(DateTime date, DateTime startTime, DateTime endTime, int parkingAreaId);

        Task<int> CreateAsync(int driverId,int parkingAreaId , NewReservationDto reservation);

        Task UpdateReservationStateAsync(ReservationDto reservation, ReservationStateEnum newState);

        Task CancelReservationAsync(ReservationDto reservation);

        Task DeleteAsync(int reservationId);
    }
}