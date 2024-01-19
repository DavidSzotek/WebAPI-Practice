using Microsoft.EntityFrameworkCore;
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
            var newMaterialtype = new Models.Materialtype
            {
                Name = request.Name
            };

            _context.Materialtypes.Add(newMaterialtype);
            await _context.SaveChangesAsync();          
        }

        public async Task DeleteMaterialtypeById(int id)
        {
            var materialtype = await _context.Materialtypes.FindAsync(id);
            _context.Materialtypes.Remove(materialtype);
            await _context.SaveChangesAsync();
        }

        public async Task<List<MaterialtypeResponse>> GetAllMaterialtypes()
        {
            var materialtypes = await _context.Materialtypes.Select(x => new MaterialtypeResponse()
            {
                Name = x.Name,
            }).ToListAsync();

            return materialtypes;
        }

        public async Task<MaterialtypeResponse> GetMaterialtypeById(int id)
        {
            var materialtype = await _context.Materialtypes.Where(x => x.Id == id).Select(x => new MaterialtypeResponse()
            {
                Name = x.Name,
            }).FirstOrDefaultAsync();

            return materialtype;
        }

        public async Task UpdateMaterialtype(int id, MaterialtypeRequest request)
        {
            var materialtype = await _context.Materialtypes.FindAsync(id);

            materialtype.Name = request.Name;

            _context.Materialtypes.Update(materialtype);
            await _context.SaveChangesAsync();
        }
    }
}
