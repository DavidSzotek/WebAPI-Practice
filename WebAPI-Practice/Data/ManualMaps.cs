using WebAPI_Practice.DTOs.Functiontypes;
using WebAPI_Practice.DTOs.Manufacturers;
using WebAPI_Practice.DTOs.Materials;
using WebAPI_Practice.DTOs.Materialtypes;
using WebAPI_Practice.DTOs.Offices;
using WebAPI_Practice.DTOs.Printers;
using WebAPI_Practice.DTOs.Printerstatuses;
using WebAPI_Practice.DTOs.Printertypes;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.Data
{
    public static class ManualMaps
    {
        public static FunctiontypeResponse GetFunctiontypeResponseFromDto(this Functiontype functiontype)
        {
            return new FunctiontypeResponse()
            {
                    Name = functiontype.Name
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

        public static OfficeResponse GetOfficeResponseFromDto(this Office office)
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

        public static PrinterJoinedResponse GetPrinterResponseResponseFromDto(this Printer printer)
        {
            return new PrinterJoinedResponse()
            {
            };
        }

        public static PrinterstatusResponse GetPrinterstatusResponseFromDto(this Printerstatus printerstatus)
        {
            return new PrinterstatusResponse()
            {
                Name = printerstatus.Name,
            };
        }

        public static PrintertypeResponse GetPrintertypeResponseFromDto(this Printertype printer)
        {
            return new PrintertypeResponse()
            {
                Id= printer.Id,
                ModelName = printer.ModelName,
                IsColor = printer.IsColor,
                IsA3 = printer.IsA3,
                Functiontype = printer.Functiontype.GetFunctiontypeResponseFromDto(),
                Manufacturer = printer.Manufacturer.GetManufacturerResponseFromDto()
            };
        }

        public static PrintertypeResponseForPrinter GetPrintertypeResponseForPrinterFromDto(this Printertype printer) => new PrintertypeResponseForPrinter()
        {
            Id = printer.Id,
            ModelName = printer.ModelName,
            IsColor = printer.IsColor,
            IsA3 = printer.IsA3,
            Functiontype = printer.Functiontype,
            Manufacturer = printer.Manufacturer
        };

        /*TODO*/
        public static ManufacturerResponse GetManufacturerResponseForPrinterFromDto(this Manufacturer manufacturer)
        {
            return new ManufacturerResponse()
            {
                Name = manufacturer.Name,
            };
        }

        public static FunctiontypeResponse GetFunctiontypeResponseForPrinterFromDto(this Functiontype functiontype)
        {
            return new FunctiontypeResponse()
            {
                Name = functiontype.Name
            };
        }

    }
}
