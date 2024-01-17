using System.ComponentModel.DataAnnotations;

namespace WebAPI_Practice.DTOs.Manufacturers
{
    public class ManufacturerResponse
    {

        public string Name { get; set; } = null!;

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public string? ManufacturerImageUri { get; set; }
    }
}
