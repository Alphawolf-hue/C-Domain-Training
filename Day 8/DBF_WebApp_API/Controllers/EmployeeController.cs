using DBF_WebApp_API.Models;
using DBF_WebApp_API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBF_WebApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/employees
        [HttpGet]

        public IActionResult GetAllEmployees()
        {
            var employees = _employeeService.GetAllEmployees();
            if (employees == null || employees.Count == 0)
            {
                return NotFound("No employees found.");
            }
            return Ok(employees);
        }

        // GET: api/employees/5
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound($"Employee with ID {id} not found.");
            }
            return Ok(employee);
        }

        // POST: api/employees
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Invalid employee data.");
            }

            int employeeId = _employeeService.AddNewEmployee(employee);
            if (employeeId == 0)
            {
                return BadRequest("Failed to add employee.");
            }

            return CreatedAtAction(nameof(GetEmployeeById), new { id = employeeId }, employee);
        }

        // PUT: api/employees/5
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return BadRequest("Employee ID mismatch.");
            }

            string result = _employeeService.UpdateEmployee(employee);
            if (result == "Employee not found for update.")
            {
                return NotFound($"Employee with ID {id} not found.");
            }
            return Ok(result);
        }

        // DELETE: api/employees/5
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            string result = _employeeService.DeleteEmployee(id);
            if (result.Contains("not found"))
            {
                return NotFound(result);
            }
            return Ok(result);
        }
    }
}
