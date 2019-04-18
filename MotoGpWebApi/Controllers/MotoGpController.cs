using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MotoGpWebApi.Service;
using MotoGpWebApi.Models;

namespace MotoGpWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotoGpController : ControllerBase
    {
        private readonly IMotoGpService _motoGpService;

        public MotoGpController(IMotoGpService motoGpService)
        {
            _motoGpService = motoGpService;
        }
        
        [HttpGet]
        public IList<EventDTO> GetEvents()
        {
            return _motoGpService.GetEvents();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EventDetailDTO>> GetEventDetailAsync(int id)
        {
            var eventDetail = await _motoGpService.GetEventDetailAsync(id);

            if (eventDetail == null)
            {
                return new NotFoundResult();
            }

            return new OkObjectResult(eventDetail);
        }
    }
}
