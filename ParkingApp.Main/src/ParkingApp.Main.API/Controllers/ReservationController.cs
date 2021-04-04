using System;
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

        public ReservationController(IReservationService reservationService, IDriverService driverService)
        {
            _reservationService = reservationService ?? throw new ArgumentNullException(nameof(reservationService));
            _driverService = driverService ?? throw new ArgumentNullException(nameof(driverService));
        }

        [HttpGet(Name = "GetDriverReservations")]
        public async Task<IActionResult> GetDriverReservations(int driverId)
        {
            try
            {
                var driver = await _driverService.GetByIdAsync(driverId);

                if (driver == null)
                {
                    return NotFound("Cont nevalid.");
                }
                
                var rezervations = await _reservationService.GetDriverReservationsAsync(driverId);

                return Ok(rezervations);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation.");
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
                
                if (await _reservationService.ReservationExistsAsync(startTime, endTime, parkingAreaId))
                {
                    return BadRequest("Interval nevalid.");
                }

                if(date.Date < DateTime.Now.Date && 
                    (startTime.TimeOfDay < DateTime.Now.TimeOfDay || endTime.TimeOfDay < DateTime.Now.TimeOfDay))
                {
                    return BadRequest("Nu puteti selecta o ora din trecut.");
                }

                if ((endTime - startTime).TotalHours < 1)
                {
                    return BadRequest("Perioada minima de rezervare este de o ora.");
                }

                if(DateTime.Now == date && (DateTime.Now - startTime).TotalMinutes < 30)
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