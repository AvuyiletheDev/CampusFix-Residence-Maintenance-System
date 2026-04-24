using CampusFix.Domain.Entities;
using CampusFix.Infrastructure.Repositories.InMemory;

namespace CampusFix.Tests.Repositories;

public class InMemoryMaintenanceRequestRepositoryTests
{
    [Fact]
    public void Save_ShouldCreateOrUpdateRequest()
    {
        var repository = new InMemoryMaintenanceRequestRepository();
        var request = new MaintenanceRequest("MR-001", "Leaking Tap", "Bathroom tap is leaking", "S-001");
        repository.Save(request);

        request.Submit();
        repository.Save(request);

        var result = repository.FindById("MR-001");

        Assert.NotNull(result);
        Assert.Equal(MaintenanceRequestStatus.Submitted, result!.Status);
    }

    [Fact]
    public void FindByStudentId_ShouldReturnOnlyMatchingRequests()
    {
        var repository = new InMemoryMaintenanceRequestRepository();
        repository.Save(new MaintenanceRequest("MR-001", "Leaking Tap", "Bathroom tap is leaking", "S-001"));
        repository.Save(new MaintenanceRequest("MR-002", "Broken Light", "Corridor light not working", "S-002"));
        repository.Save(new MaintenanceRequest("MR-003", "Door Lock", "Door lock stuck", "S-001"));

        var results = repository.FindByStudentId("S-001");

        Assert.Equal(2, results.Count);
    }

    [Fact]
    public void Delete_ShouldRemoveRequest()
    {
        var repository = new InMemoryMaintenanceRequestRepository();
        repository.Save(new MaintenanceRequest("MR-001", "Leaking Tap", "Bathroom tap is leaking", "S-001"));

        repository.Delete("MR-001");

        Assert.Null(repository.FindById("MR-001"));
    }
}
