using WebAPI_Practice.Data;
using WebAPI_Practice.DTOs.Offices;

namespace WebAPI_Practice.Services.Office
{
    public class OfficeService : IOfficeService
    {
        private readonly DataContext _context;

        public OfficeService(DataContext context)
        {
            _context = context;
        }

        public async Task CreateOffice(OfficeRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteOfficeById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OfficeResponse>> GetAllOffices()
        {
            throw new NotImplementedException();
        }

        public async Task<OfficeResponse> GetOfficeById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateOffice(int id, OfficeRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
