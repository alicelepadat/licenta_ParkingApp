using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingApp.Main.Dtos;
using ParkingApp.Main.Services.Contracts;
using System;
using System.Threading.Tasks;

namespace ParkingApp.Main.API.Controllers
{
    [ApiController]
    [Route("api/drivers")]
    public class DriverController : ControllerBase
    {
        private readonly IDriverService _driverService;

        public DriverController(IDriverService driverService)
        {
            _driverService = driverService ?? throw new ArgumentNullException(nameof(driverService));
        }
        
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetDriverByUserId(int userId, bool includeVehicles = false)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var driver = await _driverService.GetByUSerIdAsync(userId, includeVehicles);

                if (driver == null)
                {
                    return NotFound("Soferul nu exista.");
                }

                return Ok(driver);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPut("license/{driverId}")]
        public async Task<IActionResult> AddDrivingLicense(int driverId, [FromBody] NewDrivingLicenseDto license)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var driver = await _driverService.GetByUSerIdAsync(driverId, false);

                if (driver == null)
                {
                    return NotFound("Soferul nu exista.");
                }

                await _driverService.UpdateLicenseAsync(driverId, license);

                return Ok(license);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPut("{driverId}")]
        public async Task<IActionResult> UpdateDriver(int driverId, [FromBody] DriverDto driver)
        {
            try
            {
                if (driver.Id != driverId)
                {
                    ModelState.AddModelError(
                        "Identifier",
                        "Request body not apropiate for ID");
                }

                var driverExist = await _driverService.GetByUSerIdAsync(driverId);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (driverExist == null)
                {
                    return NotFound("Soferul nu exista");
                }

                await _driverService.UpdateDriverAsync(driver);

                var updatedDriver = await _driverService.GetByUSerIdAsync(driverId, true);

                return Ok(updatedDriver);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
