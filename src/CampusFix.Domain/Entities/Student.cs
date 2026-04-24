using CampusFix.Domain.Interfaces;

namespace CampusFix.Domain.Entities;

public class Student : IIdentifiable<string>
{
    public string Id { get; init; }
    public string StudentNumber { get; private set; }
    public string FullName { get; private set; }
    public string ResidenceName { get; private set; }
    public string RoomNumber { get; private set; }

    public Student(string id, string studentNumber, string fullName, string residenceName, string roomNumber)
    {
        Id = id;
        StudentNumber = studentNumber;
        FullName = fullName;
        ResidenceName = residenceName;
        RoomNumber = roomNumber;
    }

    public void UpdateResidenceDetails(string residenceName, string roomNumber)
    {
        ResidenceName = residenceName;
        RoomNumber = roomNumber;
    }
}
