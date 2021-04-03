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
        private readonly IMapper _mapper;

        public ReservationController(IReservationService reservationService, IDriverService driverService, IMapper mapper)
        {
            _reservationService = reservationService ?? throw new ArgumentNullException(nameof(reservationService));
            _driverService = driverService ?? throw new ArgumentNullException(nameof(driverService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
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
                        return BadRequest("Aveti deja o rezervare activa in zona aleas.");
                    }
                }

                var startTime = DateTime.Parse(reservation.StartTime, System.Globalization.CultureInfo.CurrentCulture);
                var endTime = DateTime.Parse(reservation.EndTime, System.Globalization.CultureInfo.CurrentCulture);
                
                if (await _reservationService.ReservationExistsAsync(startTime, endTime, parkingAreaId))
                {
                    return BadRequest("Interval nevalid.");
                }

                if((endTime - startTime).TotalHours < 1)
                {
                    return BadRequest("Perioada minima de rezervare este de o ora.");
                }

                if(DateTime.Now == reservation.ReservationDate && (DateTime.Now - startTime).TotalMinutes < 30)
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
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}