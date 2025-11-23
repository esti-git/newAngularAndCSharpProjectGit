using Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {

        IBll.BllInterface e;
        public EventController(IBll.BllInterface e)
        {
            this.e = e;

        }
        [HttpGet]
        public async Task<List<DtoEvent>> GetEventAsync()
        {
            return await e.GetAllEvents();
        }
    }
}
