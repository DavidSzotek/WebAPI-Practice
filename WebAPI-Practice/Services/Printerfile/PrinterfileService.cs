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

        public Task CreatePrinterfile(PrinterfileRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeletePrinterfileById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PrinterfileResponse>> GetAllPrinterfiles()
        {
            throw new NotImplementedException();
        }

        public Task<PrinterfileResponse> GetPrinterfileById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePrinterfile(int id, PrinterfileRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
