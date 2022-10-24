using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_2._2.Models;
using WebAPI_2._2.Services.CalenderEntryService;

namespace WebAPI_2._2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalenderEntryController : ControllerBase
    {
        private readonly ICalenderEntryService _calenderEntryService;

        public CalenderEntryController(ICalenderEntryService calenderEntryService)
        {
            _calenderEntryService = calenderEntryService;
        }

        [HttpGet]
        public IActionResult GetCalenderEntries()
        {
            IList<CalenderEntry> result = _calenderEntryService.GetCalenderEntries();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetCalenderEntry(int id)
        {
            CalenderEntry result = _calenderEntryService.GetCalenderEntry(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateCalenderEntry(CalenderEntry entry)
        {
            IList<CalenderEntry> result = _calenderEntryService.CreateCalenderEntry(entry);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateCalenderEntry(CalenderEntry entry)
        {
            IList<CalenderEntry> result = _calenderEntryService.UpdateCalenderEntry(entry);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCalenderEntry(int id)
        {
            IList<CalenderEntry> result = _calenderEntryService.DeleteCalenderEntry(id);
            return Ok(result);
        }
    }
}