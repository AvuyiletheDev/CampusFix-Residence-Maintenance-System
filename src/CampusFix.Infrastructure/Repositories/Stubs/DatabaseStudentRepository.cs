using CampusFix.Domain.Entities;
using CampusFix.Domain.Interfaces;

namespace CampusFix.Infrastructure.Repositories.Stubs;

public class DatabaseStudentRepository : IStudentRepository
{
    public void Save(Student entity)
    {
        // TODO: Persist to SQL or NoSQL storage in a future assignment.
        throw new NotImplementedException("Database repository is a future storage backend stub.");
    }

    public Student? FindById(string id)
    {
        throw new NotImplementedException("Database repository is a future storage backend stub.");
    }

    public IReadOnlyList<Student> FindAll()
    {
        throw new NotImplementedException("Database repository is a future storage backend stub.");
    }

    public void Delete(string id)
    {
        throw new NotImplementedException("Database repository is a future storage backend stub.");
    }
}
