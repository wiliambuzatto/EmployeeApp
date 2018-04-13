using EmployeeApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.API.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Employee> Employee { get; set; }
    }
}