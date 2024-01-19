using WebAPI_Practice.DTOs.Functiontypes;
using WebAPI_Practice.DTOs.Manufacturers;
using WebAPI_Practice.DTOs.Materials;
using WebAPI_Practice.DTOs.Materialtypes;
using WebAPI_Practice.DTOs.Offices;
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

        public static MaterialtypeResponse GetMaterialtypeResponseFromDto(this Materialtype materialtype)
        {
            return new MaterialtypeResponse()
            {
                Name = materialtype.Name,
            };
        }

        public static OfficeResponse GetOfficetypeResponseFromDto(this Office office)
        {
            return new OfficeResponse()
            {
                Id = office.Id,
                City = office.City,
                Street = office.Street,
                Code = office.Code
            };
        }

        public static MaterialResponse GetMaterialResponseFromDto(this Material material)
        {
            return new MaterialResponse()
            {
                PartNumber = material.PartNumber,
                Name = material.Name,
                Color = material.Color,
                IsAlternative = material.IsAlternative,
                IsAvailable = material.IsAvailable,
                Capacity = material.Capacity,
                Price = material.Price,
                PriceDph = material.PriceDph,
                Materialtype = material.Materiatltype.GetMaterialtypeResponseFromDto()
            };
        }
    }
}
