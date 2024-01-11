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
    }
}
