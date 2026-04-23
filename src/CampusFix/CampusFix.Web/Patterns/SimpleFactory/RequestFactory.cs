using CampusFix.Web.Models.Domain;

namespace CampusFix.Web.Patterns.SimpleFactory
{
    public static class RequestFactory
    {
        public static MaintenanceRequest CreateRequest(string category)
        {
            return category.ToLower() switch
            {
                "electrical" => new MaintenanceRequest
                {
                    Category = "Electrical",
                    Priority = "High"
                },
                "plumbing" => new MaintenanceRequest
                {
                    Category = "Plumbing",
                    Priority = "Medium"
                },
                "furniture" => new MaintenanceRequest
                {
                    Category = "Furniture",
                    Priority = "Low"
                },
                _ => throw new ArgumentException("Invalid category")
            };
        }
    }
}