using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebAPI_Practice.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }

        [Url]
        public string? ManufacturerImageUri { get; set; }

        public List<Printertype> Printertypes { get; set; }
    }
}
