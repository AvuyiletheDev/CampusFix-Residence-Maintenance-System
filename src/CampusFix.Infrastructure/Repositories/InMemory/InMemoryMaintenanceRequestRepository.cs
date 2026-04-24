using CampusFix.Domain.Entities;
using CampusFix.Domain.Interfaces;

namespace CampusFix.Infrastructure.Repositories.InMemory;

public class InMemoryMaintenanceRequestRepository : InMemoryRepository<MaintenanceRequest, string>, IMaintenanceRequestRepository
{
    public IReadOnlyList<MaintenanceRequest> FindByStudentId(string studentId)
    {
        return Storage.Values.Where(r => r.StudentId == studentId).ToList().AsReadOnly();
    }

    public IReadOnlyList<MaintenanceRequest> FindByStatus(MaintenanceRequestStatus status)
    {
        return Storage.Values.Where(r => r.Status == status).ToList().AsReadOnly();
    }
}
