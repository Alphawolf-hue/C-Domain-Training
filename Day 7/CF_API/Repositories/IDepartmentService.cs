using CF_API.Models;

namespace CF_API.Repositories
{
    public interface IDepartmentService
    {
        List<Department> GetAllDepartments();
        Department GetDepartmentById(int id);
        int AddNewDepartment(Department department);
        string UpdateDepartment(Department department);
        string DeleteDepartment(int id); 
    }
}
