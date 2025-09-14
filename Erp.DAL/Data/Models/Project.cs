namespace Erp.DAL.Data.Models
{
    public class Project
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Budget { get; set; }

        public ICollection<ProjectAssignment> Assignments { get; set; } = new HashSet<ProjectAssignment>();
    }
}