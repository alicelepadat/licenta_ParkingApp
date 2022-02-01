using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingApp.Main.Common.Enums;
using ParkingApp.Main.Dtos;
using ParkingApp.Main.Services.Contracts;

namespace ParkingApp.Main.API.Controllers
{
    [ApiController]
    [Route("api/reservations")]
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        private readonly IDriverService _driverService;
        private readonly IParkingAreaService _areaService;
        private readonly IVehicleService _vehicleService;

        public ReservationController(IReservationService reservationService, IDriverService driverService, IParkingAreaService areaService, IVehicleService vehicleService)
        {
            _reservationService = reservationService ?? throw new ArgumentNullException(nameof(reservationService));
            _driverService = driverService ?? throw new ArgumentNullException(nameof(driverService));
            _areaService = areaService ?? throw new ArgumentNullException(nameof(areaService));
            _vehicleService = vehicleService ?? throw new ArgumentNullException(nameof(vehicleService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReservations()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var allReservations = await _reservationService.GetReservationsAsync();

                foreach (var r in allReservations)
                {
                    await _reservationService.UpdateReservationStateAsync(r);

                }

                return Ok(allReservations);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }

        [HttpGet("{driverId}", Name = "GetDriverReservations")]
        public async Task<IActionResult> GetDriverReservations(int driverId)
        {
            try
            {
                var driver = await _driverService.GetByUSerIdAsync(driverId, true);

                if (driver == null)
                {
                    return NotFound("Autentificati-va pentru a vedea rezervarile.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var allReservations = await _reservationService.GetDriverReservationsAsync(driver.Id);

                foreach (var r in allReservations)
                {
                    await _reservationService.UpdateReservationStateAsync(r);

                }

                return Ok(allReservations);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }

        [HttpGet("{vehicleId}/vehicle")]
        public async Task<IActionResult> GetVehicleReservations(int vehicleId)
        {
            try
            {
                var vehicle = await _vehicleService.GetByIdAsync(vehicleId, true);

                if (vehicle == null)
                {
                    return NotFound("Autentificati-va pentru a vedea rezervarile.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var reservations = vehicle.DriverReservations;

                foreach (var r in reservations)
                {
                    await _reservationService.UpdateReservationStateAsync(r);

                }

                return Ok(reservations);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }

        [HttpGet("{areaId}/area")]
        public async Task<IActionResult> GetParkingAreaReservations(int areaId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var reservations = await _reservationService.GetParkingAreaReservationsAsync(areaId);

                foreach (var r in reservations)
                {
                    await _reservationService.UpdateReservationStateAsync(r);

                }

                return Ok(reservations);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }

        [HttpGet]
        [Route("{parkingAreaId}/intervals")]
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

        [HttpPost("{parkingAreaId}")]
        public async Task<IActionResult> CreateReservation(int? driverId, int parkingAreaId, NewReservationDto reservation)
        {
            try
            {
                var area = await _areaService.GetAreaByIdAsync(parkingAreaId);

                if (area == null && area.AvailableSpots <= 0)
                {
                    return BadRequest("Nu exista locuri disponibile.");
                }

                IEnumerable<ReservationDto> reservations = null;

                if (driverId != null)
                {
                    reservations = await _reservationService.GetDriverReservationsAsync((int)driverId);
                }
                else
                {
                    reservations = await _reservationService.GetVehiclesReservationsAsync(reservation.Vehicle.LicensePlate);
                }

                var date = DateTime.Parse(reservation.ReservationDate, System.Globalization.CultureInfo.CurrentCulture);
                var startTime = DateTime.Parse(reservation.StartTime, System.Globalization.CultureInfo.CurrentCulture);
                var endTime = DateTime.Parse(reservation.EndTime, System.Globalization.CultureInfo.CurrentCulture);

                foreach (var r in reservations)
                {
                    if (r.ReservationDate.Date == date && (r.State == ReservationStateEnum.ACTIVE || r.State == ReservationStateEnum.IN_PROGRESS))
                    {
                        return BadRequest("Aveti deja o rezervare activa astazi.");
                    }
                }

                if (await _reservationService.ReservationExistsAsync(date, startTime, endTime, parkingAreaId))
                {
                    return BadRequest("Interval nevalid.");
                }

                if (date.Date < DateTime.Now.Date || date.Date == DateTime.Now.Date)
                {
                    if (startTime.TimeOfDay < DateTime.Now.TimeOfDay || endTime.TimeOfDay < DateTime.Now.TimeOfDay)
                    {
                        return BadRequest("Nu puteti selecta o ora din trecut.");
                    }
                }

                if ((endTime - startTime).TotalHours < 1)
                {
                    return BadRequest("Perioada minima de rezervare este de o ora.");
                }

                if (DateTime.Now.Date == date.Date && (startTime.TimeOfDay - DateTime.Now.TimeOfDay).TotalMinutes < 30)
                {
                    return BadRequest("Puteti rezerva cu minim 30 de minute inainte.");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var inserted = new ReservationDto();

                if (driverId != null)
                {
                    var driver = await _driverService.GetByUSerIdAsync((int)driverId, true);

                    if (driver != null)
                    {
                        inserted = await _reservationService.CreateAsync(driver.Id, parkingAreaId, reservation);
                    }
                }
                else
                {
                    inserted = await _reservationService.CreateAsync(null, parkingAreaId, reservation);
                }

                if (inserted == null)
                {
                    return Problem();
                }

                return Ok(inserted);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation.");
            }
        }

        [HttpPut("{reservationId}/cancel")]
        public async Task<IActionResult> CancelReservation(int driverId, int reservationId)
        {
            try
            {
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

                return Ok(reservation);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }

        [HttpPut("{reservationId}/payment")]
        public async Task<IActionResult> UpdateReservationPayment(int reservationId)
        {
            try
            {
                var reservationExist = await _reservationService.GetByIdAsync(reservationId);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (reservationExist == null)
                {
                    return NotFound("Rezervarea nu exista");
                }

                await _reservationService.UpdateReservationPaymentAsync(reservationId);

                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpDelete]
        [Route("{reservationId}/delete")]
        public async Task<IActionResult> DeleteReservation(int reservationId)
        {
            try
            {
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

        [HttpPut]
        [Route("updateState")]
        public async Task<IActionResult> UpdateReservtionsState()
        {
            try
            {
                var reservations = await this._reservationService.GetReservationsAsync();
                
                foreach(var reservation in reservations)
                {
                    await this._reservationService.UpdateReservationStateAsync(reservation);
                }

                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation.");
            }
        }
    }
}