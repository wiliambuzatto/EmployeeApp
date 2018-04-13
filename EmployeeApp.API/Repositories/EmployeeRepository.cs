using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApp.API.Models;
using EmployeeApp.API.Queries;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.API.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }
        
        public async Task<Employee> Create(Employee employee)
        {
            await _context.Employee.AddAsync(employee);
            await _context.SaveChangesAsync();

            return employee;
        }

        public async Task<IList<GetAllEmployeesQueryResult>> GetAll()
        {
            return await _context.Employee.Select(e => new GetAllEmployeesQueryResult{
                Id = e.Id,
                FullName = e.FullName,
                Email = e.Email,
                Salary = e.Salary,
                TaxRangeApplied = e.TaxRangeApplied,
                TaxDeductionSalary = e.TaxDeductionSalary
            }).ToListAsync();
            
        }

        public async Task<bool> Delete(int id)
        {
            var employee = await _context.Employee.SingleOrDefaultAsync(e => e.Id == id);
            if (employee == null) 
                return false;
                
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}