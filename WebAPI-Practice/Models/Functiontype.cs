using System.ComponentModel.DataAnnotations;

namespace WebAPI_Practice.Models
{
    public class Functiontype
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        public List<Printertype> Printertypes { get; set; }
    }
}
