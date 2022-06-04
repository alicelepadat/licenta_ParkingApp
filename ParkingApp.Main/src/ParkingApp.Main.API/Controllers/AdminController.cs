using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingApp.Main.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingApp.Main.API.Controllers
{
    [Route("api/admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService ?? throw new ArgumentNullException(nameof(adminService));
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

                var admin = await _adminService.GetAdminByUserIdAsync(userId);

                if (admin == null)
                {
                    return NotFound("Adminul nu exista.");
                }

                return Ok(admin);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpDelete("{adminId}")]
        public async Task<IActionResult> DeleteAdminAccount(int adminId)
        {
            try
            {
                await this._adminService.DeleteAdminAccountAsync(adminId);

                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
