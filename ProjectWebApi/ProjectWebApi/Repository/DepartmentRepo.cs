using Microsoft.AspNetCore.Mvc;
using ProjectWebApi.Context;
using ProjectWebApi.Interface;
using ProjectWebApi.Models;

namespace ProjectWebApi.Repository
{
    public class DepartmentRepo : DepartmentInterface
    {

        NstDbConext _db;
        public DepartmentRepo(NstDbConext db) 
        {
            _db = db;
        }
        public void AddDepartment(Department department)
        {
            _db.Departments.Add(department);
            _db.SaveChanges();
        }

        public void DeleteDepartment(int id)
        {
            Department department = _db.Departments.FirstOrDefault(x => x.Id == id);    
            if(department != null)
            {
                _db.Departments.Remove(department);
                _db.SaveChanges();
            }
        }

        public void EditDepartment(int id, Department department)
        {
            Department department1 = _db.Departments.FirstOrDefault(x => x.Id==id); 
            if(department1 != null)
            {
                foreach (Department temp in _db.Departments)
                {
                    if (temp.Id == id)
                    { 
                        temp.DepartmentName = department.DepartmentName;
                        

                    }
                }
                
                _db.SaveChanges();  
            }
          
        }

        public Department GetDepartmentById(int id)
        {
            Department department = _db.Departments.FirstOrDefault(x => x.Id == id);
            return department;
        }

        public List<Department> GetDepartments()
        {
            return _db.Departments.ToList();
        }
    }
}
