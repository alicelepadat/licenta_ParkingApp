using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingApp.Main.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingApp.Main.API.Controllers
{
    [Route("api/areas")]
    [ApiController]
    public class ParkingAreaController : ControllerBase
    {
        private readonly IParkingAreaService _parkingAreaService;

        public ParkingAreaController(IParkingAreaService parkingAreaService)
        {
            _parkingAreaService = parkingAreaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllParkingAreas()
        {
            try
            {
                var areas = await _parkingAreaService.GetAllAreasAsync();

                return Ok(areas);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }
    }
}
