using System.ComponentModel.DataAnnotations;

namespace WebAPI_Practice.DTOs.Manufacturers
{
    public class ManufacturerRequest
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }
    }
}
