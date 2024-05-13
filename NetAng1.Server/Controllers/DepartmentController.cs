using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetAng1.Server.Models;
using System.Xml.Linq;

namespace NetAng1.Server.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class DepartmentController : Controller
    {
        private readonly SchoolContext _schoolContext;
        public DepartmentController(SchoolContext schoolContext){
            _schoolContext = schoolContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDepartments(){
            var employees = await _schoolContext.Departments.ToListAsync();
            return Ok(employees);
        }
        [HttpGet("{name}")]
        public async Task<IActionResult> GetDepartmentByName(string name)
        {
            //Since department names are unique, this will return the one and only department.
            var department = await _schoolContext.Departments.FirstOrDefaultAsync(d=>d.Name == name);
            if (department == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(department);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddDepartment([FromBody] Department departmentRequest)
        {
            await _schoolContext.Departments.AddAsync(departmentRequest);
            await _schoolContext.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDepartmentByName([FromBody] Department departmentRequest)
        {
            var departmentToUpdate = await _schoolContext.Departments.FirstOrDefaultAsync(d => d.Name == departmentRequest.Name);

            if (departmentToUpdate == null)
            {
                return NotFound();
            }
            else
            {
                departmentToUpdate.Location = departmentRequest.Location;
                departmentToUpdate.HeadProfessorId = departmentRequest.HeadProfessorId;
                await _schoolContext.SaveChangesAsync();
                return Ok();
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartmentByName(int id)
        {
            var departmentToDelete = await _schoolContext.Departments.FindAsync(id);

            if (departmentToDelete == null)
            {
                return NotFound();
            }
            else
            {
                _schoolContext.Remove(departmentToDelete);
                await _schoolContext.SaveChangesAsync();
                return Ok();
            }
        }
    }
}
