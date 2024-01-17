using System.ComponentModel.DataAnnotations;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.DTOs.Printertypes
{
    public class PrintertypeRequest
    {
        [Required]
        public string ModelName { get; set; } = null!;

        [Required]
        public bool IsColor { get; set; }

        [Required]
        public bool IsA3 { get; set; }

        [Required]
        public int FunctiontypeId { get; set; }

        [Required]
        public int ManufacturerId { get; set; }
    }
}
