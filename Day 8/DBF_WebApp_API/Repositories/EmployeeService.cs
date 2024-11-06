using DBF_WebApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DBF_WebApp_API.Repositories
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmpmanagementSystemContext _context;

        public EmployeeService(EmpmanagementSystemContext context)
        {
            _context = context;
        }

        public List<Employee> GetAllEmployees()
        {
            var employees = _context.Employees.Include(d=>d.Dept).ToList();
            return employees.Count > 0 ? employees : null;
        }

        public int AddNewEmployee(Employee employee)
        {
            try
            {
                if (employee != null)
                {
                    _context.Employees.Add(employee);
                    _context.SaveChanges();
                    return employee.EmployeeId;
                }
                return 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string DeleteEmployee(int employeeId)
        {
            if (employeeId != 0)
            {
                var employee = _context.Employees.FirstOrDefault(x => x.EmployeeId == employeeId);
                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                    return $"The given employee with ID {employeeId} has been removed.";
                }
                return "Employee not found for deletion.";
            }
            return "ID should not be null or zero.";
        }

        public Employee GetEmployeeById(int employeeId)
        {
            if (employeeId != 0)
            {
                var employee = _context.Employees.FirstOrDefault(x => x.EmployeeId == employeeId);
                return employee ?? null;
            }
            return null;
        }

        public string UpdateEmployee(Employee employee)
        {
            var existingEmployee = _context.Employees.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
            if (existingEmployee != null)
            {
                existingEmployee.EmployeeName = employee.EmployeeName;
                existingEmployee.Salary = employee.Salary;
                existingEmployee.DeptId = employee.DeptId;

                _context.Entry(existingEmployee).State = EntityState.Modified;
                _context.SaveChanges();
                return "Employee updated successfully.";
            }
            return "Employee not found for update.";
        }
    }
}
