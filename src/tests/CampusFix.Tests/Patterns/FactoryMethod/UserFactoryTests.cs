using CampusFix.Web.Models.Domain;
using CampusFix.Web.Patterns.FactoryMethod;
using Xunit;

namespace CampusFix.Tests.Patterns.FactoryMethod
{
    public class UserFactoryTests
    {
        [Fact]
        public void StudentFactory_ShouldCreateStudent()
        {
            IUserFactory factory = new StudentFactory();

            var user = factory.CreateUser();

            Assert.NotNull(user);
            Assert.IsType<Student>(user);
            Assert.Equal("Student", user.GetRole());
        }

        [Fact]
        public void TechnicianFactory_ShouldCreateTechnician()
        {
            IUserFactory factory = new TechnicianFactory();

            var user = factory.CreateUser();

            Assert.NotNull(user);
            Assert.IsType<Technician>(user);
            Assert.Equal("Technician", user.GetRole());
        }

        [Fact]
        public void AdminFactory_ShouldCreateAdmin()
        {
            IUserFactory factory = new AdminFactory();

            var user = factory.CreateUser();

            Assert.NotNull(user);
            Assert.IsType<Admin>(user);
            Assert.Equal("Admin", user.GetRole());
        }
    }
}