namespace CampusFix.Web.Models.Domain
{
    public class Student : User
    {
        public string StudentNumber { get; set; } = string.Empty;
        public int ResidenceId { get; set; }

        public override string GetRole()
        {
            return "Student";
        }
    }
}
