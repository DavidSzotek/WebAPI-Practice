using System.ComponentModel.DataAnnotations;

namespace WebAPI_Practice.Models
{
    public class Printerfile
    {
        public int Id { get; set; }

        [Required]
        public string FileName { get; set; } = null!;

        [Required]
        [Url]
        public string FileUri { get; set; } = null!;

        [Required]
        public int PrinterId { get; set; }
        [Required]
        public Printer Printer { get; set; } = null!;
    }
}
