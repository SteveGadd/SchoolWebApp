using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetAng1.Server.Models;

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

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] Department departmentRequest)
        {
            await _schoolContext.Departments.AddAsync(departmentRequest);
            return Ok();
        }
    }
}
