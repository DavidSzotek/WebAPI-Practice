using WebAPI_Practice.DTOs.Printers;

namespace WebAPI_Practice.Services.Printer
{
    public interface IPrinterService
    {       
        public Task<PrinterJoinedResponse> GetPrinterById(int id);

        public Task<List<PrinterJoinedResponse>> GetAllPrinters();

        public Task CreatePrinter(PrinterRequest request);

        public Task UpdatePrinter(int id, PrinterRequest request);

        public Task DeletePrinterById(int id);         
    }
}
