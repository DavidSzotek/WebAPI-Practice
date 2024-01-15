using System.ComponentModel.DataAnnotations;

namespace WebAPI_Practice.Models
{
    public class Office
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string Street { get; set; } = null!;

        [Required]
        [MaxLength(6)]
        public string ZipCode { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Municipality { get; set; } = null!;

        [Required]
        [MaxLength(15)]
        public string Code { get; set; } = null!;

        public List<Printer> Printers { get; set; }

        public List<Stock> Stocks { get; set; }
    }
}
