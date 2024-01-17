using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Practice.DTOs.Functiontypes;
using WebAPI_Practice.DTOs.Manufacturers;
using WebAPI_Practice.Models;
using WebAPI_Practice.Services.Functiontype;
using WebAPI_Practice.Services.ManufacturerService;

namespace WebAPI_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FunctiontypeController : ControllerBase
    {
        private readonly IFunctiontypeService _functiontypeService;

        public FunctiontypeController(IFunctiontypeService functiontypeService)
        {
            _functiontypeService = functiontypeService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Manufacturer>> GetFunctiontypeById([FromRoute] int id)
        {
            var functiontype = await _functiontypeService.GetFunctiontypeById(id);
            if (functiontype == null)
            {
                return NotFound();
            }
            return Ok(functiontype);
        }

        [HttpGet()]
        public async Task<ActionResult<List<Functiontype>>> GetAllFunctiontypes()
        {
            var functiontypes = await _functiontypeService.GetAllFunctiontypes();
            return Ok(functiontypes);
        }

        [HttpPost()]
        public async Task<ActionResult> CreateFunctiontype([FromBody] FunctiontypeRequest request)
        {
            await _functiontypeService.CreateFunctiontype(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateFunctiontype([FromRoute]int id, [FromBody] FunctiontypeRequest request)
        {
            if(request == null)
            {
                return NotFound();
            }
            await _functiontypeService.UpdateFunctiontype(id, request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteFunctiontypeById([FromRoute] int id)
        {
            await _functiontypeService.DeleteFunctiontypeById(id);
            return Ok();
        }
    }
}
