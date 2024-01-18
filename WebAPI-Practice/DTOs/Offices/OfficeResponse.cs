using System.ComponentModel.DataAnnotations;

namespace WebAPI_Practice.DTOs.Offices
{
    public class OfficeResponse
    {
        public int Id { get; set; }

        public string City { get; set; } = null!;

        public string Street { get; set; } = null!;

        public string Code { get; set; } = null!;
    }
}
