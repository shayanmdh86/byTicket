using App.Domain.Core.Bus.Data;
using App.Domain.Core.Bus.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusQueryRepo _repo;
        public BusController(IBusQueryRepo busQuery)
        {
            _repo = busQuery;
        }

        [HttpPost]
        public IActionResult PostBus(BusInputDto busInputDto)
        {
            if (busInputDto != null)
            {
                _repo.InsertBuses(busInputDto);
                return Ok(busInputDto);
                

            }
            return BadRequest();
        }
    }
}
