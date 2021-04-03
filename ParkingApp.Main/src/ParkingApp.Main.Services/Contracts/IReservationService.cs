using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ParkingApp.Main.Dtos;

namespace ParkingApp.Main.Services.Contracts
{
    public interface IReservationService
    {
        Task<IEnumerable<ReservationDto>> GetDriverReservationsAsync(int driverId);

        Task<ReservationDto> GetByIdAsync(int reservattionId);
        
        Task<bool> ReservationExistsAsync(DateTime startTime, DateTime endTime, int parkingAreaId);

        Task<int> CreateAsync(int driverId,int parkingAreaId , NewReservationDto reservation);

        Task DeleteAsync(int reservationId);
    }
}