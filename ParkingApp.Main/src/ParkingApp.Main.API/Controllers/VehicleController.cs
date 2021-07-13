using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingApp.Main.Dtos;
using ParkingApp.Main.Services.Contracts;
using System;
using System.Threading.Tasks;

namespace ParkingApp.Main.API.Controllers
{
    [Route("api/drivers/{driverId}/vehicles")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;
        private readonly IDriverService _driverService;

        public VehicleController(IVehicleService vehicleService, IDriverService driverService)
        {
            _vehicleService = vehicleService ?? throw new ArgumentNullException(nameof(vehicleService));
            _driverService = driverService ?? throw new ArgumentNullException(nameof(driverService));
        }

        [HttpGet("/api/vehicle/{vehicleId}")]
        public async Task<IActionResult> GetVehicleById(int vehicleId)
        {
            try
            {
                var vehicle = await _vehicleService.GetByIdAsync(vehicleId);

                if (vehicle == null)
                {
                    return NotFound("Vehiculul solicitat nu exista.");
                }

                return Ok(vehicle);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation.");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetDriverVehicles(int driverId)
        {
            try
            {
                var driver = await _driverService.GetByUSerIdAsync(driverId, true);
                
                if (driver == null)
                {
                    return NotFound("Cont nevalid.");
                }

                var vehicles = driver.Vehicles;

                return Ok(vehicles);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateVehicle(int driverId, NewVehicleDto vehicle)
        {
            try
            {
                var driver = await _driverService.GetByUSerIdAsync(driverId, true);

                if (driver == null)
                {
                    return NotFound("Cont nevalid.");
                }

                if(driver.Vehicles.Count > 4)
                {
                    return BadRequest("Nu puteti adauga mai mult de 4 vehicule.");
                }

                if(await _vehicleService.VehicleExistsAsync(driver.Id, vehicle.LicensePlate))
                {
                    return BadRequest("Vehicul deja adaugat.");
                }

                var inserted = await _vehicleService.CreateAsync(driver.Id, vehicle);

                return Ok(inserted);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation.");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteVehicle(int driverId, int vehicleId)
        {
            try
            {
                var driver = await _driverService.GetByUSerIdAsync(driverId);

                if (driver == null)
                {
                    return NotFound("Cont nevalid.");
                }

                if(await _vehicleService.GetByIdAsync(vehicleId) == null)
                {
                    return NotFound("Nu exista vehiculul specificat.");
                }

                await _vehicleService.DeleteAsync(vehicleId);

                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
