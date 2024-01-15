using WebAPI_Practice.Data;

namespace WebAPI_Practice.Services.Printer
{
    public class PrinterService : IPrinterService
    {
        private readonly DataContext _context;

        public PrinterService(DataContext context)
        {
            _context = context;
        }
    }
}
