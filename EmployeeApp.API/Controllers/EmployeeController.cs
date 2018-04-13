using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeApp.API.Commands;
using EmployeeApp.API.Models;
using EmployeeApp.API.Queries;
using EmployeeApp.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.API.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _repo;
    
        public EmployeeController(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody]CreateEmployeeCommand command)
        {
            var employee = new Employee(command.FullName, command.Email, command.Salary);

            var createEmployee = await _repo.Create(employee);

            return StatusCode(201);
        }

        [HttpGet("get")]
        public async Task<IEnumerable<GetAllEmployeesQueryResult>> GetAll(){
             return await _repo.GetAll();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute]int id){
            if(!await _repo.Delete(id))
                return BadRequest("Funcionário não existe");
            
            return StatusCode(200);
        }
    }
}