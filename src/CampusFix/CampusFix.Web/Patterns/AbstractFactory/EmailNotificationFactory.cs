namespace CampusFix.Web.Patterns.AbstractFactory
{
    public class EmailNotificationFactory : INotificationFactory
    {
        public INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}