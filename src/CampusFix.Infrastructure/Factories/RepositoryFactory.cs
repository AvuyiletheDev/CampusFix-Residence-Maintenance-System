using CampusFix.Domain.Interfaces;
using CampusFix.Infrastructure.Repositories.InMemory;
using CampusFix.Infrastructure.Repositories.Stubs;

namespace CampusFix.Infrastructure.Factories;

public static class RepositoryFactory
{
    public static IStudentRepository CreateStudentRepository(RepositoryStorageType storageType) =>
        storageType switch
        {
            RepositoryStorageType.Memory => new InMemoryStudentRepository(),
            RepositoryStorageType.Database => new DatabaseStudentRepository(),
            _ => throw new ArgumentOutOfRangeException(nameof(storageType), storageType, "Unsupported repository storage type.")
        };

    public static ITechnicianRepository CreateTechnicianRepository(RepositoryStorageType storageType) =>
        storageType switch
        {
            RepositoryStorageType.Memory => new InMemoryTechnicianRepository(),
            RepositoryStorageType.Database => throw new NotImplementedException("Database technician repository stub can be added later."),
            _ => throw new ArgumentOutOfRangeException(nameof(storageType), storageType, "Unsupported repository storage type.")
        };

    public static IAdminRepository CreateAdminRepository(RepositoryStorageType storageType) =>
        storageType switch
        {
            RepositoryStorageType.Memory => new InMemoryAdminRepository(),
            RepositoryStorageType.Database => throw new NotImplementedException("Database admin repository stub can be added later."),
            _ => throw new ArgumentOutOfRangeException(nameof(storageType), storageType, "Unsupported repository storage type.")
        };

    public static IMaintenanceRequestRepository CreateMaintenanceRequestRepository(RepositoryStorageType storageType) =>
        storageType switch
        {
            RepositoryStorageType.Memory => new InMemoryMaintenanceRequestRepository(),
            RepositoryStorageType.Database => throw new NotImplementedException("Database maintenance request repository stub can be added later."),
            _ => throw new ArgumentOutOfRangeException(nameof(storageType), storageType, "Unsupported repository storage type.")
        };
}
