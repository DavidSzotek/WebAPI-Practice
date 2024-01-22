using System.ComponentModel.DataAnnotations;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.DTOs.Stocks
{
    public class StockRequest
    {
        public int Quantity { get; set; }

        [Required]
        public int OfficeId { get; set; }

        [Required]
        public int MaterialId { get; set; }
    }
}
