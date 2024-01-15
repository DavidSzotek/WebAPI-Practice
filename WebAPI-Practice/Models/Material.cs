using System.ComponentModel.DataAnnotations;

namespace WebAPI_Practice.Models
{
    public class Material
    {
        public int Id { get; set; }

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
        public int Capacity { get; set; }

        public double Price { get; set; }
        public double PriceDph { get; set; }

        [Required]
        public int MaterialtypeId { get; set; }
        [Required]
        public Materialtype Materiatltype { get; set; } = null!;

        public List<Printertype> Printertypes { get; set; }

        public List<Stock> Stocks { get; set; }
    }
}
