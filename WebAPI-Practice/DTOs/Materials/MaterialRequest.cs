using System.ComponentModel.DataAnnotations;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.DTOs.Materials
{
    public class MaterialRequest
    {
        [Required]
        [MaxLength(50)]
        public string PartNumber { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = null!;

        [MaxLength(25)]
        public string? Color { get; set; }

        [Required]
        public bool IsAlternative { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public int Capacity { get; set; }

        public double Price { get; set; }

        public double PriceDph { get; set; }

        [Required]
        public int MaterialtypeId { get; set; }

    }
}
