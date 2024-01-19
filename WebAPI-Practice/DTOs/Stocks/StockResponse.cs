using System.ComponentModel.DataAnnotations;
using WebAPI_Practice.DTOs.Materials;
using WebAPI_Practice.DTOs.Offices;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.DTOs.Stocks
{
    public class StockResponse
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public OfficeResponse Office { get; set; } = null!;

        public MaterialResponse Material { get; set; } = null!;
    }
}
