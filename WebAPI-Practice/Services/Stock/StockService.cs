using WebAPI_Practice.Data;
using WebAPI_Practice.DTOs.Stocks;

namespace WebAPI_Practice.Services.Stock
{
    public class StockService : IStockService
    {
        private readonly DataContext _context;

        public StockService(DataContext context)
        {
            _context = context;
        }

        public async Task CreateStock(StockRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteStockById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<StockResponse>> GetAllStocks()
        {
            throw new NotImplementedException();
        }

        public async Task<StockResponse> GetStockById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateStock(int id, StockRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
