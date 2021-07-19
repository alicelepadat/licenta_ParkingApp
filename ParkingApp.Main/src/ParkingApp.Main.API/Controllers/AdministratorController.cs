using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingApp.Main.Services.Contracts;
using System;
using System.Threading.Tasks;

namespace ParkingApp.Main.API.Controllers
{
    [Route("api/administrator")]
    [ApiController]
    public class AdministratorController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AdministratorController(IAuthService authService)
        {
            _authService = authService ?? throw new ArgumentNullException(nameof(authService));
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetAdminByUserId(int userId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var administrator = await _authService.GetUserByIdAsync(userId);

                if (administrator == null)
                {
                    return NotFound("Administratorul nu exista.");
                }

                return Ok(administrator);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
