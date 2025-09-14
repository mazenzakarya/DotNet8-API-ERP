namespace Erp.DAL.Data.Models
{
    public class Payroll
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaidBy { get; set; }
    }
}