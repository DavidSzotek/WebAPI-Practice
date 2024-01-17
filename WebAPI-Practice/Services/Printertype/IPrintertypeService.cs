using WebAPI_Practice.DTOs.Printertypes;

namespace WebAPI_Practice.Services.Printertype
{
    public interface IPrintertypeService
    {
        public Task<PrintertypeResponse> GetPrintertypeById(int id);

        public Task<List<PrintertypeResponse>> GetAllPrintertypes();

        public Task CreatePrintertype(PrintertypeRequest request);

        public Task UpdatePrintertype(int id, PrintertypeRequest request);

        public Task DeletePrintertypeById(int id);
    }
}
