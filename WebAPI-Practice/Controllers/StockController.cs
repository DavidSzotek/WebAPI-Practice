using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Practice.DTOs.Stocks;
using WebAPI_Practice.Models;
using WebAPI_Practice.Services.Stock;

namespace WebAPI_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Stock>> GetStockById([FromRoute] int id)
        {
            var stock = await _stockService.GetStockById(id);
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock);
        }

        [HttpGet]
        public async Task<ActionResult<Stock>> GetAllStocks()
        {
            var stocks = await _stockService.GetAllStocks();
            return Ok(stocks);
        }

        [HttpPost]
        public async Task<ActionResult> CreateStock([FromBody] StockRequest request)
        {
            await _stockService.CreateStock(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateStock([FromRoute] int id, [FromBody] StockRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            await _stockService.UpdateStock(id, request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStockById([FromRoute] int id)
        {
            await _stockService.DeleteStockById(id);
            return Ok();
        }
    }
}
