using CampusFix.Web.Models.Domain;

namespace CampusFix.Web.Patterns.FactoryMethod
{
    public class AdminFactory : IUserFactory
    {
        public User CreateUser()
        {
            return new Admin();
        }
    }
}