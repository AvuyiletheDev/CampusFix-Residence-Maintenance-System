using CampusFix.Infrastructure.Factories;
using CampusFix.Infrastructure.Repositories.InMemory;

namespace CampusFix.Tests.Repositories;

public class RepositoryFactoryTests
{
    [Fact]
    public void CreateStudentRepository_WhenMemorySelected_ShouldReturnInMemoryRepository()
    {
        var repository = RepositoryFactory.CreateStudentRepository(RepositoryStorageType.Memory);

        Assert.IsType<InMemoryStudentRepository>(repository);
    }

    [Fact]
    public void CreateStudentRepository_WhenDatabaseSelected_ShouldReturnDatabaseStub()
    {
        var repository = RepositoryFactory.CreateStudentRepository(RepositoryStorageType.Database);

        Assert.NotNull(repository);
    }
}
