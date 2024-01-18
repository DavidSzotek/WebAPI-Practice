using WebAPI_Practice.Data;
using WebAPI_Practice.DTOs.Materials;

namespace WebAPI_Practice.Services.Material
{
    public class MaterialService : IMaterialService
    {
        private readonly DataContext _context;

        public MaterialService(DataContext context)
        {
            _context = context;
        }

        public async Task CreateMaterial(MaterialRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteMaterialById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MaterialResponse>> GetAllMaterials()
        {
            throw new NotImplementedException();
        }

        public async Task<MaterialResponse> GetMaterialById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateMaterial(int id, MaterialRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
