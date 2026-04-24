using CampusFix.Domain.Entities;
using CampusFix.Domain.Interfaces;

namespace CampusFix.Infrastructure.Repositories.InMemory;

public class InMemoryStudentRepository : InMemoryRepository<Student, string>, IStudentRepository
{
}
