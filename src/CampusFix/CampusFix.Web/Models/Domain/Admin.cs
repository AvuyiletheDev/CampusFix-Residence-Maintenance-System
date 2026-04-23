namespace CampusFix.Web.Models.Domain
{
    public class Admin : User
    {
        public string StaffNumber { get; set; } = string.Empty;

        public override string GetRole()
        {
            return "Admin";
        }
    }
}
