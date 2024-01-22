using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Practice.DTOs.Materialtypes;
using WebAPI_Practice.Models;
using WebAPI_Practice.Services.Materialtype;

namespace WebAPI_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialtypeController : ControllerBase
    {
        private readonly IMaterialtypeService _materialtypeService;

        public MaterialtypeController(IMaterialtypeService materialtypeService)
        {
            _materialtypeService = materialtypeService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Materialtype>> GetMaterialtypeById([FromRoute] int id)
        {
            var materialtype = await _materialtypeService.GetMaterialtypeById(id);
            if(materialtype == null)
            {
                return NotFound();
            }
            return Ok(materialtype);
        }

        [HttpGet]
        public async Task<ActionResult<List<Materialtype>>> GetAllMaterialtypes()
        {
            var materialtypes = await _materialtypeService.GetAllMaterialtypes();
            return Ok(materialtypes);
        }

        [HttpPost]
        public async Task<ActionResult> CreateMaterialtype([FromBody] MaterialtypeRequest request)
        {
            await _materialtypeService.CreateMaterialtype(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateMaterialtype([FromRoute] int id, [FromBody] MaterialtypeRequest request)
        {
            if(request == null)
            {
                return BadRequest();
            }
            await _materialtypeService.UpdateMaterialtype(id, request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMaterialtypeById([FromRoute] int id)
        {
            await _materialtypeService.DeleteMaterialtypeById(id);
            return Ok();
        }
    }
}
