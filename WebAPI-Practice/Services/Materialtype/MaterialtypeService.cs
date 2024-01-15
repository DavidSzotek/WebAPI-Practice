using WebAPI_Practice.Data;

namespace WebAPI_Practice.Services.Materialtype
{
    public class MaterialtypeService : IMaterialtypeService
    {
        private readonly DataContext _context;

        public MaterialtypeService(DataContext context)
        {
            _context = context;
        }
    }
}
