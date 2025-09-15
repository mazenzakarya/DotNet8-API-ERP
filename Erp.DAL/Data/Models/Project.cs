namespace Erp.DAL.Data.Models
{
    public class Project
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Budget { get; set; }

        public ICollection<ProjectAssignment> Assignments { get; set; } = new HashSet<ProjectAssignment>();
    }
}