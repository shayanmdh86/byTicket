using App.Domain.Core.Passenger.AppService;
using App.Domain.Core.Passenger.Data;
using App.Domain.Core.Passenger.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassangerController : ControllerBase
    {
        private readonly IPassengerAppService _passengerAppService;

        public PassangerController(IPassengerAppService passengerAppService)
        {
            _passengerAppService = passengerAppService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPassenger()
        {
            var passengers=await _passengerAppService.GetPassengers();
            return Ok(passengers);
        }

        
    }
}
