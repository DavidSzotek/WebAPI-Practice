using Microsoft.EntityFrameworkCore;
using WebAPI_Practice.Data;
using WebAPI_Practice.DTOs.Printerfiles;

namespace WebAPI_Practice.Services.Printerfile
{
    public class PrinterfileService : IPrinterfileService
    {
        private readonly DataContext _context;

        public PrinterfileService(DataContext context)
        {
            _context = context;
        }

        public async Task CreatePrinterfile(PrinterfileRequest request)
        {
            var newPrinterfile = new Models.Printerfile
            {
                FileName = request.FileName,
                FileUri = request.FileUri,
                PrinterId = request.PrinterId,
            };

            _context.Printerfiles.Add(newPrinterfile);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePrinterfileById(int id)
        {
            var printerfile = await _context.Printerfiles.FindAsync(id);
            _context.Printerfiles.Remove(printerfile);
            await _context.SaveChangesAsync();
        }

        public async Task<List<PrinterfileResponse>> GetAllPrinterfiles()
        {
            var printerfiles = await _context.Printerfiles.Select(x => new PrinterfileResponse()
            {
                Id = x.Id,
                FileName = x.FileName,
                FileUri = x.FileUri
            }).ToListAsync();

            return printerfiles;
        }

        public async Task<PrinterfileResponse> GetPrinterfileById(int id)
        {
            var printerfile = await _context.Printerfiles.Where(x => x.Id == id).Select(x => new PrinterfileResponse()
            {
                Id = x.Id,
                FileName = x.FileName,
                FileUri = x.FileUri
            }).FirstOrDefaultAsync();

            return printerfile;
        }

        public async Task UpdatePrinterfile(int id, PrinterfileRequest request)
        {
            var printersfile = await _context.Printerfiles.FindAsync(id);

            printersfile.FileName = request.FileName;
            printersfile.FileUri = request.FileUri;
            printersfile.PrinterId = request.PrinterId;

            _context.Printerfiles.Update(printersfile);
            await _context.SaveChangesAsync();
        }
    }
}
