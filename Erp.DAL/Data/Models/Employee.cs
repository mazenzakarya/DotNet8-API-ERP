namespace Erp.DAL.Data.Models
{
    public class Employee
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public string NationalId { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public string JobTitle { get; set; }
    }
}