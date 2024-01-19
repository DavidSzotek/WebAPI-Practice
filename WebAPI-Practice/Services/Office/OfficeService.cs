using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Reflection.Emit;
using WebAPI_Practice.Data;
using WebAPI_Practice.DTOs.Offices;

namespace WebAPI_Practice.Services.Office
{
    public class OfficeService : IOfficeService
    {
        private readonly DataContext _context;

        public OfficeService(DataContext context)
        {
            _context = context;
        }

        public async Task CreateOffice(OfficeRequest request)
        {
            var newOffice = new Models.Office
            {
                City = request.City,
                Street = request.Street,
                ZipCode = request.ZipCode,
                Municipality = request.Municipality,
                Code = request.Code
            };

            _context.Offices.Add(newOffice);
            await _context.SaveChangesAsync();          
        }

        public async Task DeleteOfficeById(int id)
        {
            var office = await _context.Offices.FindAsync(id);
            _context.Offices.Remove(office);
            await _context.SaveChangesAsync();
        }

        public async Task<List<OfficeResponse>> GetAllOffices()
        {
            var offices = await _context.Offices.Select(x => new OfficeResponse()
            {
                Id = x.Id,
                City = x.City,
                Street = x.Street,
                Code = x.Code
            }).ToListAsync();

            return offices;
        }

        public async Task<OfficeResponse> GetOfficeById(int id)
        {
            var office = await _context.Offices.Where(x => x.Id == id).Select(x => new OfficeResponse()
            {
                Id = x.Id,
                City = x.City,
                Street = x.Street,
                Code = x.Code
            }).FirstOrDefaultAsync();

            return office;
        }

        public async Task UpdateOffice(int id, OfficeRequest request)
        {
            var office = await _context.Offices.FindAsync(id);

            office.City = request.City;
            office.Street = request.Street;
            office.ZipCode = request.ZipCode;
            office.Municipality = request.Municipality;
            office.Code = request.Code;

            _context.Offices.Update(office);
            await _context.SaveChangesAsync();
        }
    }
}
