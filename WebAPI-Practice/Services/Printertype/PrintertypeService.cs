using WebAPI_Practice.Data;

namespace WebAPI_Practice.Services.Printertype
{
    public class PrintertypeService : IPrintertypeService
    {
        private readonly DataContext _context;

        public PrintertypeService(DataContext context)
        {
            _context = context;
        }
    }
}
