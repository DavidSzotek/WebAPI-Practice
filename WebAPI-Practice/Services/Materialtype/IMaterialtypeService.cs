using WebAPI_Practice.DTOs.Materialtypes;

namespace WebAPI_Practice.Services.Materialtype
{
    public interface IMaterialtypeService
    {       
        public Task<MaterialtypeResponse> GetMaterialtypeById(int id);

        public Task<List<MaterialtypeResponse>> GetAllMaterialtypes();

        public Task CreateMaterialtype(MaterialtypeRequest request);

        public Task UpdateMaterialtype(int id, MaterialtypeRequest request);

        public Task DeleteMaterialtypeById(int id);          
    }
}
