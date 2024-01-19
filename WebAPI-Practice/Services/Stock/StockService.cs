using Microsoft.EntityFrameworkCore;
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
            var newStock = new Models.Stock
            {
                Quantity = request.Quantity,
                OfficeId = request.OfficeId,
                MaterialId = request.MaterialId
            };

            _context.Stocks.Add(newStock);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStockById(int id)
        {
            var stock = await _context.Stocks.FindAsync(id);
            _context.Stocks.Remove(stock);
            await _context.SaveChangesAsync();
        }

        public async Task<List<StockResponse>> GetAllStocks()
        {
            var stocks = await _context.Stocks.Select(x => new StockResponse()
            {
                Id = x.Id,
                Quantity = x.Quantity,
                Office = x.Office.GetOfficeResponseFromDto(),
                Material = x.Material.GetMaterialResponseFromDto(),
            }).ToListAsync();

            return stocks;
        }

        public async Task<StockResponse> GetStockById(int id)
        {
            var stock = await _context.Stocks.Select(x => new StockResponse()
            {
                Id = x.Id,
                Quantity = x.Quantity,
                Office = x.Office.GetOfficeResponseFromDto(),
                Material = x.Material.GetMaterialResponseFromDto(),
            }).FirstOrDefaultAsync();

            return stock;
        }

        public async Task UpdateStock(int id, StockRequest request)
        {
            var stock = await _context.Stocks.FindAsync(id);

            stock.Quantity = request.Quantity;
            stock.OfficeId = request.OfficeId;
            stock.MaterialId = request.MaterialId;

            _context.Stocks.Update(stock);
            await _context.SaveChangesAsync();
        }
    }
}
