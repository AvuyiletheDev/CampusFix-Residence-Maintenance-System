using CampusFix.Domain.Entities;

namespace CampusFix.Domain.Interfaces;

public interface ITechnicianRepository : IRepository<Technician, string>
{
    IReadOnlyList<Technician> FindAvailableTechnicians();
}
