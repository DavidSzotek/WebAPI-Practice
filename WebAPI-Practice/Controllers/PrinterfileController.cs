using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Practice.DTOs.Printerfiles;
using WebAPI_Practice.Models;
using WebAPI_Practice.Services.Printerfile;

namespace WebAPI_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrinterfileController : ControllerBase
    {
        private readonly IPrinterfileService _printerfileService;

        public PrinterfileController(IPrinterfileService printerfileService)
        {
            _printerfileService = printerfileService;
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Printerfile>> GetPrinterfileById([FromRoute] int id)
        {
            var printerfile = await _printerfileService.GetPrinterfileById(id);
            if (printerfile == null)
            {
                return NotFound();
            }
            return Ok(printerfile);
        }

        [HttpGet()]
        public async Task<ActionResult<List<Printerfile>>> GetAllPrinterfiles()
        {
            var printerfiles = await _printerfileService.GetAllPrinterfiles();
            return Ok(printerfiles);
        }

        [HttpPost()]
        public async Task<ActionResult> CreatePrinterfile([FromBody] PrinterfileRequest request)
        {
            await _printerfileService.CreatePrinterfile(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePrinterfile([FromRoute]int id, [FromBody] PrinterfileRequest request)
        {
            if(request == null)
            {
                return NotFound();
            }
            await _printerfileService.UpdatePrinterfile(id, request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePrinterfileById([FromRoute] int id)
        {
            await _printerfileService.DeletePrinterfileById(id);
            return Ok();
        }
    }
}
