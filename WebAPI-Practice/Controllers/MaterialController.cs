using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Practice.DTOs.Materials;
using WebAPI_Practice.Models;
using WebAPI_Practice.Services.Material;

namespace WebAPI_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        private readonly IMaterialService _materialService;

        public MaterialController(IMaterialService materialService)
        {
            _materialService = materialService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Material>> GetMaterialById([FromRoute] int id)
        {
            var material = await _materialService.GetMaterialById(id);
            if(material == null)
            {
                return NotFound();
            }
            return Ok(material);
        }

        [HttpGet]
        public async Task<ActionResult<Material>> GetAllMaterials()
        {
            var materials = await _materialService.GetAllMaterials();
            return Ok(materials);
        }

        [HttpPost]
        public async Task<ActionResult> CreateMaterial([FromBody] MaterialRequest request)
        {
            await _materialService.CreateMaterial(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateMaterial([FromRoute] int id, [FromBody] MaterialRequest request)
        {
            if(request == null)
            {
                return BadRequest();
            }
            await _materialService.UpdateMaterial(id, request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMaterialById([FromRoute] int id)
        {
            await _materialService.DeleteMaterialById(id);
            return Ok();
        }
    }
}
