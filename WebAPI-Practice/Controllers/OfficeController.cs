using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Practice.DTOs.Offices;
using WebAPI_Practice.Models;
using WebAPI_Practice.Services.Office;

namespace WebAPI_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private readonly IOfficeService _officeService;

        public OfficeController(IOfficeService officeService)
        {
            _officeService = officeService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Office>> GetOfficeById([FromRoute] int id)
        {
            var office = await _officeService.GetOfficeById(id);
            if(office == null)
            {
                return NotFound();
            }
            return Ok(office);
        }

        [HttpGet]
        public async Task<ActionResult<List<Office>>> GetAllOffices()
        {
            var offices = await _officeService.GetAllOffices();
            return Ok(offices);
        }

        [HttpPost]
        public async Task<ActionResult> CreateOffice([FromBody] OfficeRequest request)
        {
            await _officeService.CreateOffice(request);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateOffice([FromRoute] int id, [FromBody] OfficeRequest request)
        {
            if(request == null)
            {
                return BadRequest();
            }
            await _officeService.UpdateOffice(id, request);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteOfficeById(int id)
        {
            await _officeService.DeleteOfficeById(id);
            return Ok();
        }
    }
}
