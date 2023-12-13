using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSys.Model
{
    public class Salary
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public long Amount { get; set; }
        public double Total { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
    }
}