using Microsoft.AspNetCore.Mvc;
using WebAPI_Practice.DTOs.Manufacturers;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.Services.ManufacturerService
{
    public interface IManufacturerService
    {
        public Task<ManufacturerResponse> GetManufacturerById(int id);

        public Task<List<ManufacturerResponse>> GetAllManufacturers();

        public Task CreateManufacturer(ManufacturerRequest request);

        public Task UpdateManufacturer(int id, ManufacturerRequest request);

        public Task DeleteManufacturerById(int id);
    }
}
