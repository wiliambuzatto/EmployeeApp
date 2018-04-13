using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeApp.API.Models;
using EmployeeApp.API.Queries;

namespace EmployeeApp.API.Repositories
{
    public interface IEmployeeRepository
    {
         Task<IList<GetAllEmployeesQueryResult>> GetAll();
         Task<Employee> Create(Employee employee);
         Task<bool> Delete(int id);
    }
}