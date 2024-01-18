using System.ComponentModel.DataAnnotations;

namespace WebAPI_Practice.DTOs.Printerfiles
{
    public class PrinterfileRequest
    {
        [Required]
        public string FileName { get; set; } = null!;

        [Required]
        [Url]
        public string FileUri { get; set; } = null!;

        [Required]
        public int PrinterId { get; set; }
    }
}
