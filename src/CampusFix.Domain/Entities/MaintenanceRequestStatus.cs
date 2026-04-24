namespace CampusFix.Domain.Entities;

public enum MaintenanceRequestStatus
{
    Draft,
    Submitted,
    UnderReview,
    Approved,
    Assigned,
    InProgress,
    Resolved,
    Closed,
    Reopened,
    Rejected
}
