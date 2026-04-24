using CampusFix.Domain.Interfaces;

namespace CampusFix.Domain.Interfaces;

public interface IRepository<T, TId> where T : IIdentifiable<TId>
{
    void Save(T entity);
    T? FindById(TId id);
    IReadOnlyList<T> FindAll();
    void Delete(TId id);
}
