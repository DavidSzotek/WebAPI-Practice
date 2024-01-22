using Microsoft.EntityFrameworkCore;
using WebAPI_Practice.Data;
using WebAPI_Practice.DTOs.Functiontypes;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.Services.Functiontype
{
    public class FunctiontypeService : IFunctiontypeService
    {
        private readonly DataContext _context;

        public FunctiontypeService(DataContext context)
        {
            _context = context;
        }

        public async Task CreateFunctiontype(FunctiontypeRequest request)
        {
            var newManufacturer = new Models.Functiontype
            {
                Name = request.Name
            };

            _context.Functiontypes.Add(newManufacturer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFunctiontypeById(int id)
        {
            var functiontype = await _context.Functiontypes.FindAsync(id);
            _context.Functiontypes.Remove(functiontype);
            await _context.SaveChangesAsync();
        }

        public async Task<List<FunctiontypeResponse>> GetAllFunctiontypes()
        {
            var functiontypes = await _context.Functiontypes.Select(x => new FunctiontypeResponse()
            {
                Name = x.Name,
            }).ToListAsync();

            return functiontypes;
        }

        public async Task<FunctiontypeResponse> GetFunctiontypeById(int id)
        {
            var functiontype = await _context.Functiontypes.Where(x => x.Id == id).Select(x => new FunctiontypeResponse()
            {
                Name = x.Name,
            }).FirstOrDefaultAsync();

            return functiontype;
        }

        public async Task UpdateFunctiontype(int id, FunctiontypeRequest request)
        {
            var functiontype = await _context.Functiontypes.FindAsync(id);

            functiontype.Name = request.Name;

            _context.Functiontypes.Update(functiontype);
            await _context.SaveChangesAsync();
        }
    }
}
