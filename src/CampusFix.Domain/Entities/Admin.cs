using CampusFix.Domain.Interfaces;

namespace CampusFix.Domain.Entities;

public class Admin : IIdentifiable<string>
{
    public string Id { get; init; }
    public string FullName { get; private set; }
    public string EmailAddress { get; private set; }

    public Admin(string id, string fullName, string emailAddress)
    {
        Id = id;
        FullName = fullName;
        EmailAddress = emailAddress;
    }

    public void UpdateEmail(string emailAddress)
    {
        EmailAddress = emailAddress;
    }
}
