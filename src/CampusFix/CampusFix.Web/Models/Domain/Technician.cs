namespace CampusFix.Web.Models.Domain
{
    public class Technician : User
    {
        public string StaffNumber { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public bool IsAvailable { get; set; } = true;

        public override string GetRole()
        {
            return "Technician";
        }
    }
}
