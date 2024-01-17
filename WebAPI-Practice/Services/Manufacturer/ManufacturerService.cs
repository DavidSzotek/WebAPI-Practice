using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_Practice.Data;
using WebAPI_Practice.DTOs.Manufacturers;
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

        public async Task<ManufacturerResponse> GetManufacturerById(int id)
        {
            var manufacturer = await _context.Manufacturers.Where(x => x.Id == id).Select(x => new ManufacturerResponse()
            {
                Name = x.Name,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber
            }).FirstOrDefaultAsync();

            return manufacturer;
        }

        public async Task<List<ManufacturerResponse>> GetAllManufacturers()
        {
            var manufacturers = await _context.Manufacturers.Select(x => new ManufacturerResponse()
            {
                Name = x.Name,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber
            }).ToListAsync();

            return manufacturers;
        }

        public async Task CreateManufacturer(ManufacturerRequest request)
        {
            var newManufacturer = new Manufacturer
            {
                Name = request.Name,
                Description = request.Description,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber
            };

            _context.Manufacturers.Add(newManufacturer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateManufacturer(int id, ManufacturerRequest request)
        {
            var manufacturer = await _context.Manufacturers.FindAsync(id);

            manufacturer.Name = request.Name;
            manufacturer.Description = request.Description;
            manufacturer.Email = request.Email;
            manufacturer.PhoneNumber = request.PhoneNumber;

            _context.Manufacturers.Update(manufacturer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteManufacturerById(int id)
        {
            var manufacturer = await _context.Manufacturers.FindAsync(id);
            _context.Manufacturers.Remove(manufacturer);
            await _context.SaveChangesAsync();
        }
    }
}
