using System.ComponentModel.DataAnnotations;

namespace WebAPI_Practice.Models
{
    public class Printertype
    {
        public int Id { get; set; }

        [Required]
        public string ModelName { get; set; } = null!;

        public bool IsColor { get; set; }
        public bool IsA3 { get; set; }

        [Required]
        public int FunctiontypeId { get; set; }
        [Required]
        public Functiontype Functiontype { get; set; } = null!;

        [Required]
        public int ManufacturerId { get; set; }
        [Required]
        public Manufacturer Manufacturer { get; set; } = null!;

        public List<Material> Materials { get; set; }

        public List<Printer> Printers { get; set; }
    }
}