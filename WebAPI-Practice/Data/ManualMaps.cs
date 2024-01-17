using WebAPI_Practice.DTOs.Functiontypes;
using WebAPI_Practice.DTOs.Manufacturers;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.Data
{
    public static class ManualMaps
    {
        public static FunctiontypeResponse GetFunctiontypeResponseFromDto(this Functiontype functiontype)
        {
            return new FunctiontypeResponse()
            {
                Name = functiontype.Name,
            };
        }

        public static ManufacturerResponse GetManufacturerResponseFromDto(this Manufacturer manufacturer)
        {
            return new ManufacturerResponse()
            {
                Name = manufacturer.Name,
                Email = manufacturer.Email,
                PhoneNumber = manufacturer.PhoneNumber,
                ManufacturerImageUri = manufacturer.ManufacturerImageUri
            };
        }
    }
}
