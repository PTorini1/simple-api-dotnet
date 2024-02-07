using Microsoft.AspNetCore.Mvc;
using simple_api_dotnet.Models;
using simple_api_dotnet.ViewModel;

namespace simple_api_dotnet.Controllers
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employeeRepository;

        public EmployeeController(IEmployee employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpPost]
        public IActionResult Add(EmployeeViewModel employeeView)
        {
            var employee = new Employee(employeeView.Name, employeeView.Age, null);

            _employeeRepository.Add(employee);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employee = _employeeRepository.Get();

            return Ok(employee);
        }
    }
}
