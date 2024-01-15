using WebAPI_Practice.Data;

namespace WebAPI_Practice.Services.Stock
{
    public class StockService : IStockService
    {
        private readonly DataContext _context;

        public StockService(DataContext context)
        {
            _context = context;
        }
    }
}
