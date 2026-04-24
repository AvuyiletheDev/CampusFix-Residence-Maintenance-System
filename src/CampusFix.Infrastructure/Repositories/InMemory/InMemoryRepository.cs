using CampusFix.Domain.Interfaces;

namespace CampusFix.Infrastructure.Repositories.InMemory;

public abstract class InMemoryRepository<T, TId> : IRepository<T, TId>
    where T : IIdentifiable<TId>
    where TId : notnull
{
    protected readonly Dictionary<TId, T> Storage = new();

    public virtual void Save(T entity)
    {
        Storage[entity.Id] = entity;
    }

    public virtual T? FindById(TId id)
    {
        return Storage.TryGetValue(id, out var entity) ? entity : default;
    }

    public virtual IReadOnlyList<T> FindAll()
    {
        return Storage.Values.ToList().AsReadOnly();
    }

    public virtual void Delete(TId id)
    {
        Storage.Remove(id);
    }
}
