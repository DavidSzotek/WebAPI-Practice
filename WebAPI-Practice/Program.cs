using Microsoft.EntityFrameworkCore;
using WebAPI_Practice.Data;
using WebAPI_Practice.Services.Functiontype;
using WebAPI_Practice.Services.ManufacturerService;
using WebAPI_Practice.Services.Material;
using WebAPI_Practice.Services.Materialtype;
using WebAPI_Practice.Services.Office;
using WebAPI_Practice.Services.Printer;
using WebAPI_Practice.Services.Printerfile;
using WebAPI_Practice.Services.Printerstatus;
using WebAPI_Practice.Services.Printertype;
using WebAPI_Practice.Services.Stock;

var builder = WebApplication.CreateBuilder(args);

// Services

builder.Services.AddControllers();

builder.Services.AddScoped<IFunctiontypeService, FunctiontypeService>();
builder.Services.AddScoped<IManufacturerService, ManufacturerService>();
builder.Services.AddScoped<IMaterialService, MaterialService>();
builder.Services.AddScoped<IMaterialtypeService, MaterialtypeService>();
builder.Services.AddScoped<IOfficeService, OfficeService>();
builder.Services.AddScoped<IPrinterService, PrinterService>();
builder.Services.AddScoped<IPrinterfileService, PrinterfileService>();
builder.Services.AddScoped<IPrinterstatusService, PrinterstatusService>();
builder.Services.AddScoped<IPrintertypeService, PrintertypeService>();
builder.Services.AddScoped<IStockService, StockService>();

builder.Services.AddDbContext < DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
}, ServiceLifetime.Scoped);

var app = builder.Build();

// HTTP request pipeline

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
