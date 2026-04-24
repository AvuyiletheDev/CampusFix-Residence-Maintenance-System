using CampusFix.Domain.Interfaces;

namespace CampusFix.Domain.Entities;

public class Technician : IIdentifiable<string>
{
    public string Id { get; init; }
    public string FullName { get; private set; }
    public string Specialty { get; private set; }
    public bool IsAvailable { get; private set; }

    public Technician(string id, string fullName, string specialty, bool isAvailable = true)
    {
        Id = id;
        FullName = fullName;
        Specialty = specialty;
        IsAvailable = isAvailable;
    }

    public void SetAvailability(bool isAvailable)
    {
        IsAvailable = isAvailable;
    }
}
