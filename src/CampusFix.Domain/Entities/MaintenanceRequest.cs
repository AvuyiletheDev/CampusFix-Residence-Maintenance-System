using CampusFix.Domain.Interfaces;

namespace CampusFix.Domain.Entities;

public class MaintenanceRequest : IIdentifiable<string>
{
    public string Id { get; init; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string StudentId { get; private set; }
    public string? AssignedTechnicianId { get; private set; }
    public MaintenanceRequestStatus Status { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime? UpdatedAtUtc { get; private set; }

    public MaintenanceRequest(
        string id,
        string title,
        string description,
        string studentId,
        MaintenanceRequestStatus status = MaintenanceRequestStatus.Draft)
    {
        Id = id;
        Title = title;
        Description = description;
        StudentId = studentId;
        Status = status;
        CreatedAtUtc = DateTime.UtcNow;
    }

    public void Submit()
    {
        Status = MaintenanceRequestStatus.Submitted;
        UpdatedAtUtc = DateTime.UtcNow;
    }

    public void AssignTechnician(string technicianId)
    {
        AssignedTechnicianId = technicianId;
        Status = MaintenanceRequestStatus.Assigned;
        UpdatedAtUtc = DateTime.UtcNow;
    }

    public void StartWork()
    {
        Status = MaintenanceRequestStatus.InProgress;
        UpdatedAtUtc = DateTime.UtcNow;
    }

    public void Resolve()
    {
        Status = MaintenanceRequestStatus.Resolved;
        UpdatedAtUtc = DateTime.UtcNow;
    }

    public void Close()
    {
        Status = MaintenanceRequestStatus.Closed;
        UpdatedAtUtc = DateTime.UtcNow;
    }
}
