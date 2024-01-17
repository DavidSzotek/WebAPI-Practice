using WebAPI_Practice.DTOs.Functiontypes;

namespace WebAPI_Practice.Services.Functiontype
{
    public interface IFunctiontypeService
    {
        public Task<FunctiontypeResponse> GetFunctiontypeById(int id);

        public Task<List<FunctiontypeResponse>> GetAllFunctiontypes();

        public Task CreateFunctiontype(FunctiontypeRequest request);

        public Task UpdateFunctiontype(int id, FunctiontypeRequest request);

        public Task DeleteFunctiontypeById(int id);
    }
}
