using System.ComponentModel.DataAnnotations;

namespace WebAPI_Practice.DTOs.Printerstatuses
{
    public class PrinterstatusRequest
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;
    }
}
