using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSys.Model
{
    public class Payroll
    {
       public Guid Id { get; set; }
       public Guid PaymentId { get; set; }
       public string? Title { get; set; }
       public string? Type { get; set; }
       public string? Description { get; set;}
    }
}