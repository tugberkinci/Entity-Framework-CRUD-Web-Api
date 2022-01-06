using CrudExample.Entities;

namespace CrudExample.IServices
{
    public interface IDepartmentService
    {
        List<Department> GetAllData();
        Department GetById(int Id);
        string InsertNewDepartment(string Department);
        Department UpdateDepartmentById(int Id, string DepartmentName);
        Department DeleteById(int Id);
    }
}
