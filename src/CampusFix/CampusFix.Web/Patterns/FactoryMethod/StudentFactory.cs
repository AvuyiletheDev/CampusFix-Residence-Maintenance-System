using CampusFix.Web.Models.Domain;

namespace CampusFix.Web.Patterns.FactoryMethod
{
    public class StudentFactory : IUserFactory
    {
        public User CreateUser()
        {
            return new Student();
        }
    }
}