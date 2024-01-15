using WebAPI_Practice.Data;

namespace WebAPI_Practice.Services.Material
{
    public class MaterialService : IMaterialService
    {
        private readonly DataContext _context;

        public MaterialService(DataContext context)
        {
            _context = context;
        }
    }
}
