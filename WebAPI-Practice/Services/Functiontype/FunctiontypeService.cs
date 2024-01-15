using WebAPI_Practice.Data;

namespace WebAPI_Practice.Services.Functiontype
{
    public class FunctiontypeService : IFunctiontypeService
    {
        private readonly DataContext _context;

        public FunctiontypeService(DataContext context)
        {
            _context = context;
        }
    }
}
