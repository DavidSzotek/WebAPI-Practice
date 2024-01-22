using System.ComponentModel.DataAnnotations;

namespace WebAPI_Practice.DTOs.Offices
{
    public class OfficeRequest
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
    }
}
