using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _Context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _Context = context;
        }

        public List<Department> FindAll()
        {
            return _Context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
