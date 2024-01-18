using System.ComponentModel.DataAnnotations;

namespace WebAPI_Practice.DTOs.Materialtypes
{
    public class MaterialtypeRequest
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;
    }
}
