using Microsoft.EntityFrameworkCore;
using WebAPI_Practice.Data;
using WebAPI_Practice.Services.ManufacturerService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IManufacturerService, ManufacturerService>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddDbContext < DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
}, ServiceLifetime.Scoped);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
