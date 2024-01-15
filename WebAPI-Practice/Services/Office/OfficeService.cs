using WebAPI_Practice.Data;

namespace WebAPI_Practice.Services.Office
{
    public class OfficeService : IOfficeService
    {
        private readonly DataContext _context;

        public OfficeService(DataContext context)
        {
            _context = context;
        }
    }
}
