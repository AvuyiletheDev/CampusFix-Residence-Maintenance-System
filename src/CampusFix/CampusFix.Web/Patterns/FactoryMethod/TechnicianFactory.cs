using CampusFix.Web.Models.Domain;

namespace CampusFix.Web.Patterns.FactoryMethod
{
    public class TechnicianFactory : IUserFactory
    {
        public User CreateUser()
        {
            return new Technician();
        }
    }
}