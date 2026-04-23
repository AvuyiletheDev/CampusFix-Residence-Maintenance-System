namespace CampusFix.Web.Models.Domain
{
    public abstract class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

        public virtual string GetRole()
        {
            return "User";
        }
    }
}
