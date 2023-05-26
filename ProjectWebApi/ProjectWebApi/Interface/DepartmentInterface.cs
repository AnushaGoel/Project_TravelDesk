using ProjectWebApi.Models;

namespace ProjectWebApi.Interface
{
    public interface DepartmentInterface
    {
        public List<Department> GetDepartments();
        public Department GetDepartmentById(int id);
        public void AddDepartment(Department department);
        public void EditDepartment(int id, Department department);
        public void DeleteDepartment(int id);


    }
}
