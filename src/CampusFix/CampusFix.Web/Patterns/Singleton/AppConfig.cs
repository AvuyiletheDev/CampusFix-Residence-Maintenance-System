namespace CampusFix.Web.Patterns.Singleton
{
    public class AppConfig
    {
        private static AppConfig _instance;

        private AppConfig() { }

        public static AppConfig GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AppConfig();
            }
            return _instance;
        }

        public string AppName { get; set; } = "CampusFix";
    }
}