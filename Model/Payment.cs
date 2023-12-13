namespace PayrollManagementSys.Model
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public ICollection<Payroll>? Payrolls { get; set; }
    }
}