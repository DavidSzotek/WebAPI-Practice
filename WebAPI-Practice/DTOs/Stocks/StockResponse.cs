using System.ComponentModel.DataAnnotations;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.DTOs.Stocks
{
    public class StockResponse
    {
        public int Quantity { get; set; }

        public Office Office { get; set; } = null!;

        public Material Material { get; set; } = null!;
    }
}
