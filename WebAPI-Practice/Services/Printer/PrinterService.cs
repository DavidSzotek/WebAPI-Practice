using WebAPI_Practice.Data;
using WebAPI_Practice.DTOs.Printers;

namespace WebAPI_Practice.Services.Printer
{
    public class PrinterService : IPrinterService
    {
        private readonly DataContext _context;

        public PrinterService(DataContext context)
        {
            _context = context;
        }

        public Task CreatePrinter(PrinterRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeletePrinterById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PrinterResponse>> GetAllPrinters()
        {
            throw new NotImplementedException();
        }

        public Task<PrinterResponse> GetPrinterById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePrinter(int id, PrinterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
