using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingApp.Main.Dtos;
using Stripe;
using System;
using System.Threading.Tasks;

namespace ParkingApp.Main.API.Controllers
{
    [Route("api/charges")]
    [ApiController]
    public class StripeIntentController : ControllerBase
    {
        public StripeIntentController()
        {

        }

        [HttpPost]
        public IActionResult CreateIntent([FromBody] StripeChargeDto createOptions)
        {
            try
            {
                var options = new PaymentIntentCreateOptions
                {
                    Amount = createOptions.Amount,
                    Currency = "ron",
                };
                var service = new PaymentIntentService();
                var intent = service.Create(options);

                return Ok(intent.ClientSecret);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
