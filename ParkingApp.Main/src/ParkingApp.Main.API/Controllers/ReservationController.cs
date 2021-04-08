using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingApp.Main.Common.Enums;
using ParkingApp.Main.Dtos;
using ParkingApp.Main.Services.Contracts;

namespace ParkingApp.Main.API.Controllers
{
    [ApiController]
    [Route("api/drivers/{driverId}/reservations")]
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        private readonly IDriverService _driverService;
        private readonly IParkingAreaService _areaService;

        public ReservationController(IReservationService reservationService, IDriverService driverService, IParkingAreaService areaService)
        {
            _reservationService = reservationService ?? throw new ArgumentNullException(nameof(reservationService));
            _driverService = driverService ?? throw new ArgumentNullException(nameof(driverService));
            _areaService = areaService ?? throw new ArgumentNullException(nameof(areaService));
        }

        [HttpGet(Name = "GetDriverReservations")]
        public async Task<IActionResult> UpdateReservationStatus(int driverId)
        {
            try
            {
                var driver = await _driverService.GetByIdAsync(driverId, true);

                if (driver == null)
                {
                    return NotFound("Autentificati-va sau creati un cont pentru a rezerva.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var allReservations = await _reservationService.GetDriverReservationsAsync(driverId);

                foreach (var r in allReservations)
                {
                    if (r.State == ReservationStateEnum.REGISTERED && r.ReservationDate.Date == DateTime.Now.Date &&
                            r.StartTime.TimeOfDay <= DateTime.Now.TimeOfDay && DateTime.Now.TimeOfDay<=r.EndTime.TimeOfDay)
                    {
                        await _reservationService.UpdateReservationStateAsync(r, ReservationStateEnum.IN_PROGRESS);
                    }

                    if (r.State == ReservationStateEnum.IN_PROGRESS &&
                            r.EndTime.TimeOfDay <= DateTime.Now.TimeOfDay)
                    {
                        await _reservationService.UpdateReservationStateAsync(r, ReservationStateEnum.FINISHED);
                        await _areaService.UpdateAvailableSpotsAsync(r.ParkingArea);
                    }
                }

                return Ok(allReservations);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }
        
        [HttpGet]
        [Route("{parkingAreaId}")]
        public async Task<IActionResult> GetUnavailableIntervals(string reservationDate, string startTime, string endTime, int parkingAreaId)
        {
            try
            {
                var date = DateTime.Parse(reservationDate, System.Globalization.CultureInfo.CurrentCulture);
                var start = DateTime.Parse(startTime, System.Globalization.CultureInfo.CurrentCulture);
                var end = DateTime.Parse(endTime, System.Globalization.CultureInfo.CurrentCulture);

                var isAvailable = await _reservationService.ReservationExistsAsync(date, start, end, parkingAreaId);

                return Ok(isAvailable);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateReservation(int driverId, int parkingAreaId, NewReservationDto reservation)
        {
            try
            {
                var driver = await _driverService.GetByIdAsync(driverId, true);

                if (driver == null)
                {
                    return NotFound("Autentificati-va sau creati un cont pentru a rezerva.");
                }

                var rezervations = await _reservationService.GetDriverReservationsAsync(driverId);

                foreach(var r in rezervations)
                {
                    if(r.ParkingArea.Id == parkingAreaId && 
                        (r.State == ReservationStateEnum.REGISTERED || r.State == ReservationStateEnum.IN_PROGRESS))
                    {
                        return BadRequest("Aveti deja o rezervare activa in zona aleasa.");
                    }
                }
                var date = DateTime.Parse(reservation.ReservationDate, System.Globalization.CultureInfo.CurrentCulture);
                var startTime = DateTime.Parse(reservation.StartTime, System.Globalization.CultureInfo.CurrentCulture);
                var endTime = DateTime.Parse(reservation.EndTime, System.Globalization.CultureInfo.CurrentCulture);
                
                if (await _reservationService.ReservationExistsAsync(date, startTime, endTime, parkingAreaId))
                {
                    return BadRequest("Interval nevalid.");
                }

                if((date.Date <DateTime.Now.Date || date.Date == DateTime.Now.Date) && 
                    (startTime.TimeOfDay < DateTime.Now.TimeOfDay || endTime.TimeOfDay < DateTime.Now.TimeOfDay))
                {
                    return BadRequest("Nu puteti selecta o ora din trecut.");
                }

                if ((endTime - startTime).TotalHours < 1)
                {
                    return BadRequest("Perioada minima de rezervare este de o ora.");
                }

                if(DateTime.Now.Date == date.Date && (startTime.TimeOfDay - DateTime.Now.TimeOfDay).TotalMinutes < 30)
                {
                    return BadRequest("Puteti rezerva cu minim 30 de minute inainte.");
                }

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var insertedId = await _reservationService.CreateAsync(driverId, parkingAreaId, reservation);

                if (insertedId == 0)
                {
                    return Problem();
                }

                return CreatedAtRoute("GetDriverReservations", new { driverId }, insertedId);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation.");
            }
        }

        [HttpPatch("{reservationId}")]
        public async Task<IActionResult> CancelReservation(int driverId, int reservationId)
        {
            try
            {
                var driver = await _driverService.GetByIdAsync(driverId, true);

                if (driver == null)
                {
                    return NotFound("Autentificati-va sau creati un cont pentru a rezerva.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var reservation = await _reservationService.GetByIdAsync(reservationId, true);

                if (reservation == null)
                {
                    return NotFound("Rezervarea nu exista.");
                }

                await _reservationService.CancelReservationAsync(reservation);

                await _areaService.UpdateAvailableSpotsAsync(reservation.ParkingArea);

                return Ok(reservation.State);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteReservation(int driverId, int reservationId)
        {
            try
            {
                var driver = await _driverService.GetByIdAsync(driverId);

                if (driver == null)
                {
                    return NotFound("Cont nevalid.");
                }

                if(await _reservationService.GetByIdAsync(reservationId) == null)
                {
                    return NotFound("Nu exista rezervarea selectata.");
                }

                await _reservationService.DeleteAsync(reservationId);

                return Ok("Deleted");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation.");
            }
        }
    }
}