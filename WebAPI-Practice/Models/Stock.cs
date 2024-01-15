using System.ComponentModel.DataAnnotations;

namespace WebAPI_Practice.Models
{
    public class Stock
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        [Required]
        public int OfficeId { get; set; }
        [Required]
        public Office Office { get; set; } = null!;

        [Required]
        public int MaterialId { get; set; }
        [Required]
        public Material Material { get; set; } = null!;


    }
}
