using CF_API.Models;
using CF_API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CF_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeesController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Employee> employees = _service.GetAllEmployees();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            Employee employee = _service.GetEmployeeById(id);
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            int result = _service.AddNewEmployee(employee);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put(Employee employee)
        {
            string result = _service.UpdateEmployee(employee);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            string result = _service.DeleteEmployee(id);
            return Ok(result);
        }
    }
}
