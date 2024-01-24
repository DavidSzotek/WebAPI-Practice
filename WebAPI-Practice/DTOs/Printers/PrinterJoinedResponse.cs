using System.ComponentModel.DataAnnotations;
using WebAPI_Practice.DTOs.Offices;
using WebAPI_Practice.DTOs.Printerstatuses;
using WebAPI_Practice.DTOs.Printertypes;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.DTOs.Printers
{
    public class PrinterJoinedResponse
    {
        public int Id { get; set; }

        public string InventaryNumber { get; set; } = null!;

        public string SerialNumber { get; set; } = null!;

        public DateOnly ActivationDate { get; set; }

        public double Price { get; set; }

        public string PropertyType { get; set; } = null!;

        public string? PrinterImageUri { get; set; }

        public string Room { get; set; } = null!;

        public string ManufacturerName { get; set; } = null!;

        public string ModelName { get; set; } = null!;

        public string FunctiontypeName { get; set; } = null!;

        public string OfficeCode { get; set; } = null!;

        public string OfficeString { get; set; } = null!;
    }
}
