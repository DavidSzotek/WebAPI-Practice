using Microsoft.AspNetCore.Mvc;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.Services.ManufacturerService
{
    public interface IManufacturerService
    {
        public Task<ActionResult<Manufacturer>> GetManufacturerById(int id);

        public Task<ActionResult<List<Manufacturer>>> GetAllManufacturers();
    }
}
