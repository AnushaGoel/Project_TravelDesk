using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWebApi.Interface;
using ProjectWebApi.Models;

namespace ProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        DepartmentInterface _dep;
        public DepartmentController(DepartmentInterface dep)
        {
            _dep = dep;
        }

        [HttpGet]
        public List<Department> GetDepartment()
        {
            return  _dep.GetDepartments();
        }

        [HttpGet("{id}")]
        public Department GetDepartmentByID(int id) 
        {
            return  _dep.GetDepartmentById(id);
        }

        [HttpPost]
        public void Post(Department department)
        {
            _dep.AddDepartment(department); 
        }

        [HttpPut("{id}")]
        public void Put(int id , Department department)
        {
            _dep.EditDepartment(id, department);    

        }

        [HttpDelete("{id}")]
        public void Delete (int id)
        {
            _dep.DeleteDepartment(id);
        }


    }
}
