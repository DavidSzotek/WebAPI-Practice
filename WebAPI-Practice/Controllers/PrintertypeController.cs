using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Practice.DTOs.Printertypes;
using WebAPI_Practice.Models;
using WebAPI_Practice.Services.Printertype;

namespace WebAPI_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrintertypeController : ControllerBase
    {
        private readonly IPrintertypeService _printertypeService;

        public PrintertypeController(IPrintertypeService printertypeService)
        {
            _printertypeService = printertypeService;
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Printertype>> GetPrintertypeById([FromRoute] int id)
        {
            var printertype = await _printertypeService.GetPrintertypeById(id);
            if (printertype == null)
            {
                return NotFound();
            }
            return Ok(printertype);
        }

        [HttpGet()]
        public async Task<ActionResult<List<Printertype>>> GetAllPrintertypes()
        {
            var printertypes = await _printertypeService.GetAllPrintertypes();
            return Ok(printertypes);
        }

        [HttpPost()]
        public async Task<ActionResult> CreatePrintertype([FromBody] PrintertypeRequest request)
        {
            await _printertypeService.CreatePrintertype(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePrintertype([FromRoute]int id, [FromBody] PrintertypeRequest request)
        {
            if(request == null)
            {
                return NotFound();
            }
            await _printertypeService.UpdatePrintertype(id, request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePrintertypeById([FromRoute] int id)
        {
            await _printertypeService.DeletePrintertypeById(id);
            return Ok();
        }
    }
}
