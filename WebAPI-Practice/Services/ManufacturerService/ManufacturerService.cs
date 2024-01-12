using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_Practice.Data;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.Services.ManufacturerService
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly DataContext _context;

        public ManufacturerService(DataContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<Manufacturer>> GetManufacturerById(int id)
        {
            var manufacturer = await _context.Manufacturers.FirstOrDefaultAsync(m => m.Id == id);

            return manufacturer;
        }

        public async Task<ActionResult<List<Manufacturer>>> GetAllManufacturers()
        {
            var manufacturers = await _context.Manufacturers.ToListAsync();

            return manufacturers;
        }
    }
}
