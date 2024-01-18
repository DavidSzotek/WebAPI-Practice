using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Practice.DTOs.Printerstatuses;
using WebAPI_Practice.Models;
using WebAPI_Practice.Services.Printerstatus;

namespace WebAPI_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrinterstatusController : ControllerBase
    {
        private readonly IPrinterstatusService _printerstatusService;

        public PrinterstatusController(IPrinterstatusService printerstatusService)
        {
            _printerstatusService = printerstatusService;
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Printerstatus>> GetPrinterstatusById([FromRoute] int id)
        {
            var printerstatus = await _printerstatusService.GetPrinterstatusById(id);
            if (printerstatus == null)
            {
                return NotFound();
            }
            return Ok(printerstatus);
        }

        [HttpGet()]
        public async Task<ActionResult<List<Printerstatus>>> GetAllPrinterstatuses()
        {
            var printerstatuses = await _printerstatusService.GetAllPrinterstatuses();
            return Ok(printerstatuses);
        }

        [HttpPost()]
        public async Task<ActionResult> CreatePrinterstatus([FromBody] PrinterstatusRequest request)
        {
            await _printerstatusService.CreatePrinterstatus(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePrinterstatus([FromRoute]int id, [FromBody] PrinterstatusRequest request)
        {
            if(request == null)
            {
                return NotFound();
            }
            await _printerstatusService.UpdatePrinterstatus(id, request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePrinterstatusById([FromRoute] int id)
        {
            await _printerstatusService.DeletePrinterstatusById(id);
            return Ok();
        }
    }
}
