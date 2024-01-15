using WebAPI_Practice.Data;

namespace WebAPI_Practice.Services.Printerstatus
{
    public class PrinterstatusService : IPrinterstatusService
    {
        private readonly DataContext _context;

        public PrinterstatusService(DataContext context)
        {
            _context = context;
        }
    }
}
