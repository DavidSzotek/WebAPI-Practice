using System.ComponentModel.DataAnnotations;

namespace WebAPI_Practice.Models
{
    public class Printer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(9)]
        public string InventaryNumber { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string SerialNumber { get; set; } = null!;

        public DateOnly ActivationDate { get; set; }

        public double Price { get; set; }

        public string PropertyType { get; set; }

        [Required]
        [MaxLength(50)]
        public string Room { get; set; } = null!;

        [Required]
        public int OfficeId { get; set; }
        [Required]
        public Office Office { get; set; }

        [Required]
        public int PrinterstatusId { get; set; }
        [Required]
        public Printerstatus Printerstatus { get; set; }

        [Required]
        public int PrintertypeId { get; set; }
        [Required]
        public Printertype Printertype { get; set; }
    }
}
