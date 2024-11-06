using DBF_WebApp_API.Models;

namespace DBF_WebApp_API.Repositories
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        int AddNewEmployee(Employee employee);
        string UpdateEmployee(Employee employee);
        string DeleteEmployee(int id);
    }
}
