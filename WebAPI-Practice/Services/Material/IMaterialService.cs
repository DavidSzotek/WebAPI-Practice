using WebAPI_Practice.DTOs.Materials;

namespace WebAPI_Practice.Services.Material
{
    public interface IMaterialService
    {       
        public Task<MaterialResponse> GetMaterialById(int id);

        public Task<List<MaterialResponse>> GetAllMaterials();

        public Task CreateMaterial(MaterialRequest request);

        public Task UpdateMaterial(int id, MaterialRequest request);

        public Task DeleteMaterialById(int id);        
    }
}
