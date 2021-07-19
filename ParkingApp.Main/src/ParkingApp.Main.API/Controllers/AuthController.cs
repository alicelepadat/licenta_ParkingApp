using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingApp.Main.Dtos;
using ParkingApp.Main.Services.Contracts;

namespace ParkingApp.Main.API.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService ?? throw new ArgumentNullException(nameof(authService));
        }
        
        [HttpGet("{userId}/role")]
        public async Task<IActionResult> GetUserRole(int userId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if(await _authService.GetUserByIdAsync(userId) == null)
                {
                    return NotFound("Utilizatorul nu exista");
                }

                var role = await _authService.GetUserRoleAsync(userId);

                return Ok(role);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "A intervenit o eroare.");
            }
        }
        
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(AuthenticationRequestDto request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var driver = await _authService.AuthenticateAsync(request);

                if(driver == null)
                {
                    return NotFound("Email sau parola incorecte.");
                }

                return Ok(driver.Id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "A intervenit o eroare.");
            }
        }
        
        [HttpPost("driver-register")]
        public async Task<IActionResult> CreateDriver(NewDriverDto driver)
        {
            try
            {
                if (await _authService.UserExistsAsync(driver.User.Email))
                {
                    ModelState.AddModelError(
                        "Email",
                        "Email-ul corespunde unui cont existent.");
                }

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

               
                var inserted = await _authService.CreateDriverAsync(driver);

                if (inserted == null)
                {
                    return Problem("A aparut o problema la inregistrare.");
                }

                return Ok(inserted.User.Email);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
        
        [HttpPost("admin-register")]
        public async Task<IActionResult> CreateAdmin(NewAdminDto admin)
        {
            try
            {
                if (await _authService.UserExistsAsync(admin.User.Email))
                {
                    ModelState.AddModelError(
                        "Email",
                        "Email-ul corespunde unui cont existent.");
                }

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

               
                var inserted = await _authService.CreateAdminAsync(admin);

                if (inserted == null)
                {
                    return Problem("A aparut o problema la inregistrare.");
                }

                return Ok(inserted.User.Email);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPut("{userId}")]
        public async Task<IActionResult> UpdateUserPassword(int userId, [FromBody] UserDto user)
        {
            try
            {
                if (user.Id != userId)
                {
                    ModelState.AddModelError(
                        "Identifier",
                        "Request body not apropiate for ID");
                }

                var userExist = await _authService.GetUserByIdAsync(userId);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (userExist == null)
                {
                    return NotFound("Utilizatorul nu exista");
                }

                await _authService.UpdateUserAsync(user);

                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}