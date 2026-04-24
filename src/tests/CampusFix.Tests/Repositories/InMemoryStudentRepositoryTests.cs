using CampusFix.Domain.Entities;
using CampusFix.Infrastructure.Repositories.InMemory;

namespace CampusFix.Tests.Repositories;

public class InMemoryStudentRepositoryTests
{
    [Fact]
    public void Save_ShouldStore_And_FindById_ShouldReturnStudent()
    {
        var repository = new InMemoryStudentRepository();
        var student = new Student("S-001", "22001234", "Avuyile Ngalwa", "Mandela Hall", "B12");

        repository.Save(student);

        var result = repository.FindById("S-001");

        Assert.NotNull(result);
        Assert.Equal("Avuyile Ngalwa", result!.FullName);
    }

    [Fact]
    public void Delete_ShouldRemoveStudent()
    {
        var repository = new InMemoryStudentRepository();
        repository.Save(new Student("S-001", "22001234", "Avuyile Ngalwa", "Mandela Hall", "B12"));

        repository.Delete("S-001");

        Assert.Null(repository.FindById("S-001"));
    }
}
