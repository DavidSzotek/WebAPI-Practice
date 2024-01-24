using Microsoft.EntityFrameworkCore;
using WebAPI_Practice.Data;
using WebAPI_Practice.DTOs.Printerstatuses;

namespace WebAPI_Practice.Services.Printerstatus
{
    public class PrinterstatusService : IPrinterstatusService
    {
        private readonly DataContext _context;

        public PrinterstatusService(DataContext context)
        {
            _context = context;
        }

        public async Task CreatePrinterstatus(PrinterstatusRequest request)
        {
            var newPrinterstatus = new Models.Printerstatus
            {
                Name = request.Name
            };

            _context.Printerstatuses.Add(newPrinterstatus);
            await _context.SaveChangesAsync(); 
        }

        public async Task DeletePrinterstatusById(int id)
        {
            var printerstatus = await _context.Printerstatuses.FindAsync(id);
            _context.Printerstatuses.Remove(printerstatus);
            await _context.SaveChangesAsync();
        }

        public async Task<List<PrinterstatusResponse>> GetAllPrinterstatuses()
        {
            
            var printerstatuses = await _context.Printerstatuses.Select(x => new PrinterstatusResponse()
            {
                Name = x.Name,
            }).ToListAsync();

            return printerstatuses;
             
        }

        public async Task<PrinterstatusResponse> GetPrinterstatusById(int id)
        {
            var printerstatus = await _context.Printerstatuses.Where(x => x.Id == id).Select(x => new PrinterstatusResponse()
            {
                Name = x.Name,
            }).FirstOrDefaultAsync();

            return printerstatus;
        }

        public async Task UpdatePrinterstatus(int id, PrinterstatusRequest request)
        {
            var printerstatus = await _context.Printerstatuses.FindAsync(id);

            printerstatus.Name = request.Name;

            _context.Printerstatuses.Update(printerstatus);
            await _context.SaveChangesAsync();
        }
    }
}
