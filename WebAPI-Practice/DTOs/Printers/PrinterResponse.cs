using System.ComponentModel.DataAnnotations;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.DTOs.Printers
{
    public class PrinterResponse
    {
        public int Id { get; set; }

        public string InventaryNumber { get; set; } = null!;

        public string SerialNumber { get; set; } = null!;

        public DateOnly ActivationDate { get; set; }

        public double Price { get; set; }

        public string PropertyType { get; set; }

        public string? PrinterImageUri { get; set; }

        public string Room { get; set; } = null!;

        public Office Office { get; set; }

        public Printerstatus Printerstatus { get; set; }

        public Printertype Printertype { get; set; }

        public List<Printerfile> Printerfiles { get; set; }
    }
}
