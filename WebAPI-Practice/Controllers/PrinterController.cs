using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Practice.DTOs.Printers;
using WebAPI_Practice.Models;
using WebAPI_Practice.Services.Printer;

namespace WebAPI_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrinterController : ControllerBase
    {      
        private readonly IPrinterService _printerService;

        public PrinterController(IPrinterService printerService)
        {
            _printerService = printerService;
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Printer>> GetPrinterById([FromRoute] int id)
        {
            var printer = await _printerService.GetPrinterById(id);
            if (printer == null)
            {
                return NotFound();
            }
            return Ok(printer);
        }

        [HttpGet()]
        public async Task<ActionResult<List<Printer>>> GetAllPrinters()
        {
            var printers = await _printerService.GetAllPrinters();
            return Ok(printers);
        }

        [HttpPost()]
        public async Task<ActionResult> CreatePrinter([FromBody] PrinterRequest request)
        {
            await _printerService.CreatePrinter(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePrinter([FromRoute]int id, [FromBody] PrinterRequest request)
        {
            if(request == null)
            {
                return NotFound();
            }
            await _printerService.UpdatePrinter(id, request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePrinterById([FromRoute] int id)
        {
            await _printerService.DeletePrinterById(id);
            return Ok();
        }
    }
}
