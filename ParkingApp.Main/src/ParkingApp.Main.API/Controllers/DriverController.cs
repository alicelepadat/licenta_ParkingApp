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
            _driverService = driverService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDrivers()
        {
            try
            {
                var drivers = await _driverService.GetAllAsync(true, true);
                return Ok(drivers);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }

        [HttpGet("{id}", Name = "GetDriver")]
        public async Task<IActionResult> GetDriver(int id)
        {
            try
            {
                var driver = await _driverService.GetByIdAsync(id);

                if (driver == null)
                    return NotFound("Nu exista soferul cu id-ul specificat.");

                return Ok(driver);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateProvider(NewDriverDto driver)
        {
            try
            {

                if (await _driverService.DriverExistsAsync(driver.User.Name))
                {
                    ModelState.AddModelError(
                        "Name",
                        "Nu puteti adauga un sofer existent");
                }

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

               
                var inserted = await _driverService.CreateAsync(driver);

                if (inserted == null)
                    return Problem();

                return CreatedAtRoute("GetDriver", new { id = inserted.Id }, inserted);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDriver(int id, [FromBody] DriverDto driver)
        {
            try
            {
                if (driver.Id != id)
                {
                    ModelState.AddModelError(
                        "Identifier",
                        "Id incorect");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (await _driverService.GetByIdAsync(id) == null)
                {
                    return NotFound("Nu exista soferul cu id-ul specificat.");
                }

                await _driverService.UpdateAsync(driver);

                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDriver(int id)
        {
            try
            {
                if (await _driverService.GetByIdAsync(id) == null)
                {
                    return NotFound("Nu exista soferul cu id-ul specificat.");
                }

                await _driverService.DeleteAsync(id);

                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }
    }
}
