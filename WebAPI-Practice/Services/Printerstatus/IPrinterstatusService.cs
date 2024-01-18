using WebAPI_Practice.DTOs.Printerstatuses;

namespace WebAPI_Practice.Services.Printerstatus
{
    public interface IPrinterstatusService
    {
        public Task<PrinterstatusResponse> GetPrinterstatusById(int id);

        public Task<List<PrinterstatusResponse>> GetAllPrinterstatuses();

        public Task CreatePrinterstatus(PrinterstatusRequest request);

        public Task UpdatePrinterstatus(int id, PrinterstatusRequest request);

        public Task DeletePrinterstatusById(int id);
    }
}
