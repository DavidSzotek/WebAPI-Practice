using Microsoft.EntityFrameworkCore;
using WebAPI_Practice.Models;

namespace WebAPI_Practice.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Functiontype> Functiontypes { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Materialtype> Materialtypes { get; set; }
        public DbSet<Printertype> Printertypes { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<Printerfile> Printerfiles { get; set; }
        public DbSet<Printerstatus> Printerstatuses { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Stock> Stocks { get; set; }
    }
}
