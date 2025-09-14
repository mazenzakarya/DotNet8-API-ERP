namespace Erp.DAL.Data.Models
{
    public class ProjectAssignment
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Guid ProjectId { get; set; }
        public virtual Project Project { get; set; }

        public string RoleInProject { get; set; } // Engineer, Worker...
    }
}