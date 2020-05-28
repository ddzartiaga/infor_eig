using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADAGroup.EIG.Service.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADAGroup.EIG.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IActivityService _eventService;

        public EventsController(IActivityService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        [ActionName("EventsForList")]
        public IActionResult GroupsList()
        {
            try
            {
                var infos = _eventService.GetActivities();
                return Ok(infos);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}