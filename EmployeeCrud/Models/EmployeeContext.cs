using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EmployeeCrud.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }
        public DbSet <Employee> Employees { get; set; }
        public object Employee { get; internal set; }

        internal Task SavedChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
