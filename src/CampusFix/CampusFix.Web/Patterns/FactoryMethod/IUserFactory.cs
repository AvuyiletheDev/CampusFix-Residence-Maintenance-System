using CampusFix.Web.Models.Domain;

namespace CampusFix.Web.Patterns.FactoryMethod
{
    public interface IUserFactory
    {
        User CreateUser();
    }
}