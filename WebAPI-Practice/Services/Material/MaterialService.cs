using Azure.Core;
using Microsoft.EntityFrameworkCore;
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
            var newMaterial = new Models.Material
            {
                PartNumber = request.PartNumber,
                Name = request.Name,
                Color = request.Color,
                IsAlternative = request.IsAlternative,
                IsAvailable = request.IsAvailable,
                Capacity = request.Capacity,
                Price = request.Price,
                PriceDph = request.PriceDph,
                MaterialtypeId = request.MaterialtypeId
            };

            _context.Materials.Add(newMaterial);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMaterialById(int id)
        {
            var material = await _context.Materials.FindAsync(id);
            _context.Materials.Remove(material);
            await _context.SaveChangesAsync();
        }

        public async Task<List<MaterialResponse>> GetAllMaterials()
        {
            var materials = await _context.Materials.Select(x => new MaterialResponse()
            {
                PartNumber = x.PartNumber,
                Name = x.Name,
                Color = x.Color,
                IsAlternative = x.IsAlternative,
                IsAvailable = x.IsAvailable,
                Capacity = x.Capacity,
                Price = x.Price,
                PriceDph = x.PriceDph,
                Materialtype = x.Materiatltype.GetMaterialtypeResponseFromDto()
            }).ToListAsync();

            return materials;
        }

        public async Task<MaterialResponse> GetMaterialById(int id)
        {
            var material = await _context.Materials.Select(x => new MaterialResponse()
            {
                PartNumber = x.PartNumber,
                Name = x.Name,
                Color = x.Color,
                IsAlternative = x.IsAlternative,
                IsAvailable = x.IsAvailable,
                Capacity = x.Capacity,
                Price = x.Price,
                PriceDph = x.PriceDph,
                Materialtype = x.Materiatltype.GetMaterialtypeResponseFromDto()
            }).FirstOrDefaultAsync();

            return material;
        }

        public async Task UpdateMaterial(int id, MaterialRequest request)
        {
            var material = await _context.Materials.FindAsync(id);

            material.PartNumber = request.PartNumber;
            material.Name = request.Name;
            material.Color = request.Color;
            material.IsAlternative = request.IsAlternative;
            material.IsAvailable = request.IsAvailable;
            material.Capacity = request.Capacity;
            material.Price = request.Price;
            material.PriceDph = request.PriceDph;
            material.MaterialtypeId = request.MaterialtypeId;

            _context.Materials.Update(material);
            await _context.SaveChangesAsync();
        }
    }
}
