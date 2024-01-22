using WebAPI_Practice.DTOs.Offices;

namespace WebAPI_Practice.Services.Office
{
    public interface IOfficeService
    {
        public Task<OfficeResponse> GetOfficeById(int id);

        public Task<List<OfficeResponse>> GetAllOffices();

        public Task CreateOffice(OfficeRequest request);

        public Task UpdateOffice(int id, OfficeRequest request);

        public Task DeleteOfficeById(int id);
    }
}
