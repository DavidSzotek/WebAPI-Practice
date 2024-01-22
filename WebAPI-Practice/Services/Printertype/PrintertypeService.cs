using Microsoft.EntityFrameworkCore;
using WebAPI_Practice.Data;
using WebAPI_Practice.DTOs.Functiontypes;
using WebAPI_Practice.DTOs.Manufacturers;
using WebAPI_Practice.DTOs.Printertypes;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.Services.Printertype
{
    public class PrintertypeService : IPrintertypeService
    {
        private readonly DataContext _context;

        public PrintertypeService(DataContext context)
        {
            _context = context;
        }

        public async Task CreatePrintertype(PrintertypeRequest request)
        {
            var newPrintertype = new Models.Printertype
            {
                ModelName = request.ModelName,
                IsA3 = request.IsA3,
                IsColor = request.IsColor,
                ManufacturerId = request.ManufacturerId,
                FunctiontypeId = request.FunctiontypeId
            };

            _context.Printertypes.Add(newPrintertype);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePrintertypeById(int id)
        {
            var printertype = await _context.Printertypes.FindAsync(id);
            _context.Printertypes.Remove(printertype);
            await _context.SaveChangesAsync();
        }

        public async Task<List<PrintertypeResponse>> GetAllPrintertypes()
        {
            var printertype = await _context.Printertypes.Select(x => new PrintertypeResponse()
            {
                Id = x.Id,
                ModelName = x.ModelName,
                IsColor = x.IsColor,
                IsA3 = x.IsA3,
                Functiontype = x.Functiontype.GetFunctiontypeResponseFromDto(),
                Manufacturer = x.Manufacturer.GetManufacturerResponseFromDto()
            }).ToListAsync();

            return printertype;
        }

        public async Task<PrintertypeResponse> GetPrintertypeById(int id)
        {
            var printertype = await _context.Printertypes.Where(x => x.Id == id).Select(x => new PrintertypeResponse()
            {
                Id = x.Id,
                ModelName = x.ModelName,
                IsColor = x.IsColor,
                IsA3 = x.IsA3,
                Functiontype = x.Functiontype.GetFunctiontypeResponseFromDto(),
                Manufacturer = x.Manufacturer.GetManufacturerResponseFromDto()
            }).FirstOrDefaultAsync();

            /*var functiontype = await _context.Functiontypes.Where(x => x.Id == y.FunctiontypeId)
                .Select(y => new FunctiontypeResponse { Name = y.Name })*/

            return printertype;
        }

        public async Task UpdatePrintertype(int id, PrintertypeRequest request)
        {
            var printertype = await _context.Printertypes.FindAsync(id);

            printertype.ModelName = request.ModelName;
            printertype.IsColor = request.IsColor;
            printertype.IsA3 = request.IsA3;
            printertype.ManufacturerId = request.ManufacturerId;
            printertype.FunctiontypeId = request.FunctiontypeId;

            _context.Printertypes.Update(printertype);
            await _context.SaveChangesAsync();
        }
    }
}
