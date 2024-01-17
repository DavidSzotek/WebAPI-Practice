using System.ComponentModel.DataAnnotations;
using WebAPI_Practice.DTOs.Functiontypes;
using WebAPI_Practice.DTOs.Manufacturers;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.DTOs.Printertypes
{
    public class PrintertypeResponse
    {
        public int Id { get; set; }

        public string ModelName { get; set; } = null!;

        public bool IsColor { get; set; }
        public bool IsA3 { get; set; }

        public FunctiontypeResponse Functiontype { get; set; } = null!;

        public ManufacturerResponse Manufacturer { get; set; } = null!;

    }
}
