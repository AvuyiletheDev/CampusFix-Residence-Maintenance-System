namespace CampusFix.Web.Patterns.AbstractFactory
{
    public class SmsNotificationFactory : INotificationFactory
    {
        public INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }
}