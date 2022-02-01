using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingApp.Main.Services.Contracts;
using System;
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
            _parkingAreaService = parkingAreaService ?? throw new ArgumentNullException(nameof(parkingAreaService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllParkingAreas()
        {
            try
            {
                var areas = await _parkingAreaService.GetAllAreasAsync();


                return Ok(areas);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet ("{name}")]
        public async Task<IActionResult> GetAreaByName(string name)
        {
            try
            {
                var area = await _parkingAreaService.GetAreaByNameAsync(name);

                if(area == null)
                {
                    return NotFound("Nu exista zona de parcare.");
                }

                return Ok(area);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to succeed the operation!");
            }
        }
    }
}
