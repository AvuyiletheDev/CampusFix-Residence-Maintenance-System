namespace CampusFix.Web.Models.Domain
{
    public class MaintenanceRequest
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Priority { get; set; } = "Medium";
        public string Status { get; private set; } = "Draft";
        public DateTime DateCreated { get; private set; } = DateTime.UtcNow;

        public int StudentId { get; set; }
        public int? TechnicianId { get; private set; }
        public int ResidenceId { get; set; }

        public void Submit()
        {
            if (Status != "Draft")
                throw new InvalidOperationException("Only draft requests can be submitted.");

            Status = "Submitted";
        }

        public void AssignTechnician(int technicianId)
        {
            if (Status != "Submitted" && Status != "Approved")
                throw new InvalidOperationException("Only submitted or approved requests can be assigned.");

            TechnicianId = technicianId;
            Status = "Assigned";
        }

        public void StartWork()
        {
            if (Status != "Assigned")
                throw new InvalidOperationException("Only assigned requests can be started.");

            Status = "In Progress";
        }

        public void Resolve()
        {
            if (Status != "In Progress")
                throw new InvalidOperationException("Only in-progress requests can be resolved.");

            Status = "Resolved";
        }

        public void Close()
        {
            if (Status != "Resolved")
                throw new InvalidOperationException("Only resolved requests can be closed.");

            Status = "Closed";
        }
    }
}