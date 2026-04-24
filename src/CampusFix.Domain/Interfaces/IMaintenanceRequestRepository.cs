using CampusFix.Domain.Entities;

namespace CampusFix.Domain.Interfaces;

public interface IMaintenanceRequestRepository : IRepository<MaintenanceRequest, string>
{
    IReadOnlyList<MaintenanceRequest> FindByStudentId(string studentId);
    IReadOnlyList<MaintenanceRequest> FindByStatus(MaintenanceRequestStatus status);
}
