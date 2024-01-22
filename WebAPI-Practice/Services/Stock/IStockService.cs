using WebAPI_Practice.DTOs.Stocks;

namespace WebAPI_Practice.Services.Stock
{
    public interface IStockService
    {
        public Task<StockResponse> GetStockById(int id);

        public Task<List<StockResponse>> GetAllStocks();

        public Task CreateStock(StockRequest request);

        public Task UpdateStock(int id, StockRequest request);

        public Task DeleteStockById(int id);
    }
}
