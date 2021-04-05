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
        
        [HttpGet]
        public async Task<IActionResult> GetDriverVehicles(int driverId)
        {
            try
            {
                var driver = await _driverService.GetByIdAsync(driverId, true);
                
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
                var driver = await _driverService.GetByIdAsync(driverId, true);

                if (driver == null)
                {
                    return NotFound("Cont nevalid.");
                }

                if(driver.Vehicles.Count > 4)
                {
                    return BadRequest("Nu puteti adauga mai mult de 4 vehicule.");
                }

                if(await _vehicleService.VehicleExistsAsync(driverId, vehicle.LicensePlate))
                {
                    return BadRequest("Vehicul deja adaugat.");
                }

                var inserted = await _vehicleService.CreateAsync(driverId, vehicle);

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
                var driver = await _driverService.GetByIdAsync(driverId);

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
