using System.ComponentModel.DataAnnotations;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.DTOs.Printerstatuses
{
    public class PrinterstatusResponse
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
    }
}
