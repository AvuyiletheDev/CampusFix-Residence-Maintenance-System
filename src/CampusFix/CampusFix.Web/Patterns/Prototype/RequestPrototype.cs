using CampusFix.Web.Models.Domain;

namespace CampusFix.Web.Patterns.Prototype
{
    public class RequestPrototype : ICloneable
    {
        public MaintenanceRequest Request { get; set; }

        public object Clone()
        {
            return new RequestPrototype
            {
                Request = new MaintenanceRequest
                {
                    Title = Request.Title,
                    Description = Request.Description,
                    Category = Request.Category,
                    Priority = Request.Priority
                }
            };
        }
    }
}