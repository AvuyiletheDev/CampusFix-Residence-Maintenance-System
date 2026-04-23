using CampusFix.Web.Patterns.AbstractFactory;
using Xunit;

namespace CampusFix.Tests.Patterns.AbstractFactory
{
    public class NotificationFactoryTests
    {
        [Fact]
        public void EmailNotificationFactory_ShouldCreateEmailNotification()
        {
            INotificationFactory factory = new EmailNotificationFactory();

            var notification = factory.CreateNotification();

            Assert.NotNull(notification);
            Assert.IsType<EmailNotification>(notification);
        }

        [Fact]
        public void SmsNotificationFactory_ShouldCreateSmsNotification()
        {
            INotificationFactory factory = new SmsNotificationFactory();

            var notification = factory.CreateNotification();

            Assert.NotNull(notification);
            Assert.IsType<SmsNotification>(notification);
        }
    }
}