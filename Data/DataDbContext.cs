using Microsoft.EntityFrameworkCore;
using PayrollManagementSys.Model;

namespace PayrollManagementSys.Data
{
    public class DataDbContext : DbContext
    {
        // #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DataDbContext(DbContextOptions<DataDbContext> options)
            // #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }

    }
}