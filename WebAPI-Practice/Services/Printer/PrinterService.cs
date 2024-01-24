using Microsoft.EntityFrameworkCore;
using WebAPI_Practice.Data;
using WebAPI_Practice.DTOs.Printers;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI_Practice.DTOs.Printertypes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Practice.Services.Printer
{
    public class PrinterService : IPrinterService
    {
        private readonly DataContext _context;

        public PrinterService(DataContext context)
        {
            _context = context;
        }

        public async Task CreatePrinter(PrinterRequest request)
        {
            var newPrinter = new Models.Printer
            {
                InventaryNumber = request.InventaryNumber,
                SerialNumber = request.SerialNumber,
                ActivationDate = request.ActivationDate,
                Price = request.Price,
                PropertyType = request.PropertyType,
                PrinterImageUri = request.PrinterImageUri,
                Room = request.Room,
                OfficeId = request.OfficeId,
                PrinterstatusId = request.PrinterstatusId,
                PrintertypeId = request.PrintertypeId
            };

            _context.Printers.Add(newPrinter);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePrinterById(int id)
        {
            var printer = await _context.Printers.FindAsync(id);
            _context.Printers.Remove(printer);
            await _context.SaveChangesAsync();
        }

        public async Task<List<PrinterJoinedResponse>> GetAllPrinters()
        {
            /*var printers = await _context.Printers.Select(x => new PrinterResponse()
            {
                Id = x.Id,
                InventaryNumber = x.InventaryNumber,
                SerialNumber = x.SerialNumber,
                ActivationDate = x.ActivationDate,
                Price = x.Price,
                PropertyType = x.PropertyType,
                PrinterImageUri = x.PrinterImageUri,
                Room = x.Room,
                OfficeResponse = x.Office.GetOfficeResponseFromDto(),
                PrinterstatusResponse = x.Printerstatus.GetPrinterstatusResponseFromDto(),
                PrintertypeResponse =  x.Printertype.GetPrintertypeResponseForPrinterFromDto()              
            }).ToListAsync();
            */

            var printers = await _context.Printers.Select(x => new Models.Printer()
            {
                Id = x.Id,
                InventaryNumber = x.InventaryNumber,
                SerialNumber = x.SerialNumber,
                ActivationDate = x.ActivationDate,
                Price = x.Price,
                PropertyType = x.PropertyType,
                PrinterImageUri = x.PrinterImageUri,
                Room = x.Room,
                OfficeId = x.OfficeId,
                PrinterstatusId = x.PrinterstatusId,
                PrintertypeId = x.PrintertypeId
            }).ToListAsync();

            var printertypes = await _context.Printertypes.Select(x => new Models.Printertype()
            {
                Id = x.Id,
                ModelName = x.ModelName,
                ManufacturerId = x.ManufacturerId,
                FunctiontypeId = x.FunctiontypeId
            }).ToListAsync();

            var offices = await _context.Offices.Select(x => new Models.Office()
            {
                Id = x.Id,
                Code = x.Code,
                City = x.City,
                Street = x.Street
            }).ToListAsync();

            var manufacturers = await _context.Manufacturers.Select(x => new Models.Manufacturer()
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();

            var functiontypes = await _context.Functiontypes.Select(x => new Models.Functiontype()
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();

            var joinedList = from pr in printers
                             join pt in printertypes
                             on pr.PrintertypeId equals pt.Id
                             join of in offices
                             on pr.OfficeId equals of.Id
                             join mf in manufacturers
                             on pt.ManufacturerId equals mf.Id
                             join ft in functiontypes
                             on pt.FunctiontypeId equals ft.Id
                             select new
                             {
                                 Id = pr.Id,
                                 InventaryNumber = pr.InventaryNumber,
                                 SerialNumber = pr.SerialNumber,
                                 ActivationDate = pr.ActivationDate,
                                 Price = pr.Price,
                                 PropertyType = pr.PropertyType,
                                 PrinterImageUri = pr.PrinterImageUri,
                                 Room = pr.Room,
                                 ManufacturerName = mf.Name,
                                 ModelName = pt.ModelName,
                                 FunctiontypeName = ft.Name,
                                 OfficeCode = of.Code,
                                 OfficeString = $"{of.City} {of.Street}",
                             };

            List<PrinterJoinedResponse> joinedResultList = new List<PrinterJoinedResponse>();
            foreach (var printer in joinedList)
            {
                PrinterJoinedResponse response = new PrinterJoinedResponse() 
                {
                    Id = printer.Id,
                    InventaryNumber = printer.InventaryNumber,
                    SerialNumber = printer.SerialNumber,
                    ActivationDate = printer.ActivationDate,
                    Price = printer.Price,
                    PropertyType = printer.PropertyType,
                    PrinterImageUri = printer.PrinterImageUri,
                    Room = printer.Room,
                    ManufacturerName = printer.ManufacturerName,
                    ModelName = printer.ModelName,
                    FunctiontypeName = printer.FunctiontypeName,
                    OfficeCode = printer.OfficeCode,
                    OfficeString = printer.OfficeString,
                };
                joinedResultList.Add(response);
            }

            return joinedResultList;
        }

        public async Task<PrinterResponse> GetPrinterById(int id)
        {
            var printer = await _context.Printers.Where(x => x.Id == id).Select(x => new PrinterResponse()
            {
                Id = x.Id,
                InventaryNumber = x.InventaryNumber,
                SerialNumber = x.SerialNumber,
                ActivationDate = x.ActivationDate,
                Price = x.Price,
                PropertyType = x.PropertyType,
                PrinterImageUri = x.PrinterImageUri,
                Room = x.Room,
                OfficeResponse = x.Office.GetOfficeResponseFromDto(),
                PrinterstatusResponse = x.Printerstatus.GetPrinterstatusResponseFromDto(),
                PrintertypeResponse = x.Printertype.GetPrintertypeResponseForPrinterFromDto()
            }).FirstOrDefaultAsync();

            return printer;
            
        }

        public async Task UpdatePrinter(int id, PrinterRequest request)
        {
            var printer = await _context.Printers.FindAsync(id);

            printer.InventaryNumber = request.InventaryNumber;
            printer.SerialNumber = request.SerialNumber;
            printer.ActivationDate = request.ActivationDate;
            printer.Price = request.Price;
            printer.PropertyType = request.PropertyType;
            printer.PrinterImageUri = request.PrinterImageUri;
            printer.Room = request.Room;
            printer.OfficeId = request.OfficeId;
            printer.PrinterstatusId = request.PrinterstatusId;
            printer.PrintertypeId = request.PrintertypeId;

            _context.Printers.Update(printer);
            await _context.SaveChangesAsync();
        }
    }
}
