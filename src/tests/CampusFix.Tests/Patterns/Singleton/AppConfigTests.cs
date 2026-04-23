using CampusFix.Web.Patterns.Singleton;
using Xunit;

namespace CampusFix.Tests.Patterns.Singleton
{
    public class AppConfigTests
    {
        [Fact]
        public void GetInstance_ShouldReturnSameInstance()
        {
            var instance1 = AppConfig.GetInstance();
            var instance2 = AppConfig.GetInstance();

            Assert.Same(instance1, instance2);
        }

        [Fact]
        public void Singleton_ShouldPreserveSharedState()
        {
            var instance1 = AppConfig.GetInstance();
            instance1.AppName = "CampusFix";

            var instance2 = AppConfig.GetInstance();

            Assert.Equal("CampusFix", instance2.AppName);
        }
    }
}