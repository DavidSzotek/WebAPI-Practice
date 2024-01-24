using System.ComponentModel.DataAnnotations;
using WebAPI_Practice.DTOs.Printers;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.DTOs.Printerfiles
{
    public class PrinterfileResponse
    {
        public int Id { get; set; }

        public string FileName { get; set; } = null!;

        public string FileUri { get; set; } = null!;
    }
}
