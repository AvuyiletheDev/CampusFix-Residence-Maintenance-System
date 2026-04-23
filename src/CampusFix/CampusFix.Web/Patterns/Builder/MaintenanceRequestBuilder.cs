using CampusFix.Web.Models.Domain;

namespace CampusFix.Web.Patterns.Builder
{
    public class MaintenanceRequestBuilder
    {
        private readonly MaintenanceRequest _request = new MaintenanceRequest();

        public MaintenanceRequestBuilder SetTitle(string title)
        {
            _request.Title = title;
            return this;
        }

        public MaintenanceRequestBuilder SetDescription(string description)
        {
            _request.Description = description;
            return this;
        }

        public MaintenanceRequestBuilder SetCategory(string category)
        {
            _request.Category = category;
            return this;
        }

        public MaintenanceRequestBuilder SetPriority(string priority)
        {
            _request.Priority = priority;
            return this;
        }

        public MaintenanceRequest Build()
        {
            return _request;
        }
    }
}