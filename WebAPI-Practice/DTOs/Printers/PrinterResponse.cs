﻿using System.ComponentModel.DataAnnotations;
using WebAPI_Practice.DTOs.Offices;
using WebAPI_Practice.DTOs.Printerstatuses;
using WebAPI_Practice.DTOs.Printertypes;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.DTOs.Printers
{
    public class PrinterResponse
    {
        public int Id { get; set; }

        public string InventaryNumber { get; set; } = null!;

        public string SerialNumber { get; set; } = null!;

        public DateOnly ActivationDate { get; set; }

        public double Price { get; set; }

        public string PropertyType { get; set; }

        public string? PrinterImageUri { get; set; }

        public string Room { get; set; } = null!;

        public OfficeResponse OfficeResponse { get; set; } = null!;

        public PrinterstatusResponse PrinterstatusResponse { get; set; } = null!;

        public PrintertypeResponseForPrinter PrintertypeResponse { get; set; } = null!;
    }
}
