using CampusFix.Domain.Entities;
using CampusFix.Infrastructure.Repositories.InMemory;

namespace CampusFix.Tests.Repositories;

public class InMemoryTechnicianRepositoryTests
{
    [Fact]
    public void FindAvailableTechnicians_ShouldReturnOnlyAvailableTechnicians()
    {
        var repository = new InMemoryTechnicianRepository();
        repository.Save(new Technician("T-001", "Ms Jacobs", "Electrical", true));
        repository.Save(new Technician("T-002", "Mr Dlamini", "Plumbing", false));

        var available = repository.FindAvailableTechnicians();

        Assert.Single(available);
        Assert.Equal("T-001", available[0].Id);
    }
}
