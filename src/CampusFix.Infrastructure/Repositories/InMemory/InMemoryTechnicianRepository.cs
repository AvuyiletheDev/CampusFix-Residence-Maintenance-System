using CampusFix.Domain.Entities;
using CampusFix.Domain.Interfaces;

namespace CampusFix.Infrastructure.Repositories.InMemory;

public class InMemoryTechnicianRepository : InMemoryRepository<Technician, string>, ITechnicianRepository
{
    public IReadOnlyList<Technician> FindAvailableTechnicians()
    {
        return Storage.Values.Where(t => t.IsAvailable).ToList().AsReadOnly();
    }
}
