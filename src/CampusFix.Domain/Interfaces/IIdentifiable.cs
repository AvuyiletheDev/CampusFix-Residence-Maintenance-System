namespace CampusFix.Domain.Interfaces;

public interface IIdentifiable<TId>
{
    TId Id { get; }
}
