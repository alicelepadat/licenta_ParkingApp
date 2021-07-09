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

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(AuthenticationRequestDto request)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var driver = await _driverService.AuthenticateAsync(request);

                if(driver == null)
                {
                    return NotFound("Email sau parola incorecte.");
                }

                return Ok(driver.Id);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> CreateDriver(NewDriverDto driver)
        {
            try
            {
                if (await _driverService.DriverExistsAsync(driver.User.Email))
                {
                    ModelState.AddModelError(
                        "Email",
                        "Email-ul corespunde unui cont existent.");
                }

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

               
                var inserted = await _driverService.CreateAsync(driver);

                if (inserted == null)
                {
                    return Problem("A aparut o problema la inregistrare.");
                }

                return Ok(inserted.Id);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
