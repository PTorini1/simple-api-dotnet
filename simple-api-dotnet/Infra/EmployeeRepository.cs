using simple_api_dotnet.DataBase;
using simple_api_dotnet.Models;

namespace simple_api_dotnet.Infra
{
    public class EmployeeRepository : IEmployee
    {
        private readonly ConnectionContext _context;

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<Employee> Get()
        {
            return _context.Employees.ToList();
        }
    }
}
