using WebAPI_Practice.Data;
using WebAPI_Practice.DTOs.Materialtypes;

namespace WebAPI_Practice.Services.Materialtype
{
    public class MaterialtypeService : IMaterialtypeService
    {
        private readonly DataContext _context;

        public MaterialtypeService(DataContext context)
        {
            _context = context;
        }

        public async Task CreateMaterialtype(MaterialtypeRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteMaterialtypeById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MaterialtypeResponse>> GetAllMaterialtypes()
        {
            throw new NotImplementedException();
        }

        public async Task<MaterialtypeResponse> GetMaterialtypeById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateMaterialtype(int id, MaterialtypeRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
