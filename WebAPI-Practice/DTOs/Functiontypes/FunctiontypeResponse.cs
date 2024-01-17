using System.ComponentModel.DataAnnotations;

namespace WebAPI_Practice.DTOs.Functiontypes
{
    public class FunctiontypeResponse 
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;
    }
}
