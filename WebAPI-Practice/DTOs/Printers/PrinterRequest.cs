using System.ComponentModel.DataAnnotations;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.DTOs.Printers
{
    public class PrinterRequest
    {
        [Required]
        [MaxLength(9)]
        public string InventaryNumber { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string SerialNumber { get; set; } = null!;

        public DateOnly ActivationDate { get; set; }

        public double Price { get; set; }

        public string? PropertyType { get; set; }

        [Url]
        public string? PrinterImageUri { get; set; }

        [Required]
        [MaxLength(50)]
        public string Room { get; set; } = null!;

        [Required]
        public int OfficeId { get; set; }

        [Required]
        public int PrinterstatusId { get; set; }

        [Required]
        public int PrintertypeId { get; set; }
    }
}
