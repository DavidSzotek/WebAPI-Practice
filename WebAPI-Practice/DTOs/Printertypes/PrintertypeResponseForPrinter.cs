using WebAPI_Practice.Models;

namespace WebAPI_Practice.DTOs.Printertypes
{
    public class PrintertypeResponseForPrinter
    {
        public int Id { get; set; }

        public string ModelName { get; set; } = null!;

        public bool IsColor { get; set; }
        public bool IsA3 { get; set; }

        public Functiontype Functiontype { get; set; } = null!;

        public Manufacturer Manufacturer { get; set; } = null!;
    }
}
