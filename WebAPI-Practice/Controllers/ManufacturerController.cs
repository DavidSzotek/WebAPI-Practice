using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Practice.Models;
using WebAPI_Practice.Services.ManufacturerService;

namespace WebAPI_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _manufacturerService;

        public ManufacturerController(IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Manufacturer>> GetManufacturerById(int id)
        {
            var manufacturer = await _manufacturerService.GetManufacturerById(id);
            if (manufacturer.Value == null)
            {
                return NotFound();
            }
            return Ok(manufacturer);
        }

        [HttpGet()]
        public async Task<ActionResult<List<Manufacturer>>> GetAllManufacturers()
        {
            var manufacturers = await _manufacturerService.GetAllManufacturers();
            return Ok(manufacturers);
        }
    }
}
