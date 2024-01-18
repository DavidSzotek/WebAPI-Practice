using WebAPI_Practice.DTOs.Printerfiles;

namespace WebAPI_Practice.Services.Printerfile
{
    public interface IPrinterfileService
    {
        public Task<PrinterfileResponse> GetPrinterfileById(int id);

        public Task<List<PrinterfileResponse>> GetAllPrinterfiles();

        public Task CreatePrinterfile(PrinterfileRequest request);

        public Task UpdatePrinterfile(int id, PrinterfileRequest request);

        public Task DeletePrinterfileById(int id);
    }
}
