using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Practice.DTOs.Manufacturers;
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
        public async Task<ActionResult<Manufacturer>> GetManufacturerById([FromRoute] int id)
        {
            var manufacturer = await _manufacturerService.GetManufacturerById(id);
            if (manufacturer == null)
            {
                return NotFound();
            }
            return Ok(manufacturer);
        }

        [HttpGet]
        public async Task<ActionResult<List<Manufacturer>>> GetAllManufacturers()
        {
            var manufacturers = await _manufacturerService.GetAllManufacturers();
            return Ok(manufacturers);
        }

        [HttpPost()]
        public async Task<ActionResult> CreateManufacturer([FromBody] ManufacturerRequest request)
        {
            await _manufacturerService.CreateManufacturer(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateManufacturer([FromRoute]int id, [FromBody] ManufacturerRequest request)
        {
            if(request == null)
            {
                return BadRequest();
            }
            await _manufacturerService.UpdateManufacturer(id, request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteManufacturerById([FromRoute] int id)
        {
            await _manufacturerService.DeleteManufacturerById(id);
            return Ok();
        }
    }
}
