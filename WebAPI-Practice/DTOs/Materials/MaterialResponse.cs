using System.ComponentModel.DataAnnotations;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.DTOs.Materials
{
    public class MaterialResponse
    {
        public string PartNumber { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string? Color { get; set; }

        public bool IsAlternative { get; set; }

        public int Capacity { get; set; }

        public double Price { get; set; }

        public double PriceDph { get; set; }

        public Materialtype Materiatltype { get; set; } = null!;
    }
}
