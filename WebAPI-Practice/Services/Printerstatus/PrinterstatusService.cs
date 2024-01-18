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

        public Task CreatePrinterstatus(PrinterstatusRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeletePrinterstatusById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PrinterstatusResponse>> GetAllPrinterstatuses()
        {
            throw new NotImplementedException();
        }

        public Task<PrinterstatusResponse> GetPrinterstatusById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePrinterstatus(int id, PrinterstatusRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
