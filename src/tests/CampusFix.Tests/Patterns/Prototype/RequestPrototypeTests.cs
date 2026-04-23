using CampusFix.Web.Models.Domain;
using CampusFix.Web.Patterns.Prototype;
using Xunit;

namespace CampusFix.Tests.Patterns.Prototype
{
    public class RequestPrototypeTests
    {
        [Fact]
        public void Clone_ShouldCreateNewPrototypeWithCopiedRequestData()
        {
            var original = new RequestPrototype
            {
                Request = new MaintenanceRequest
                {
                    Title = "Broken Window",
                    Description = "Window cracked in Room 12",
                    Category = "Furniture",
                    Priority = "Medium"
                }
            };

            var clone = (RequestPrototype)original.Clone();

            Assert.NotNull(clone);
            Assert.NotSame(original, clone);
            Assert.NotNull(clone.Request);
            Assert.NotSame(original.Request, clone.Request);
            Assert.Equal(original.Request.Title, clone.Request.Title);
            Assert.Equal(original.Request.Description, clone.Request.Description);
            Assert.Equal(original.Request.Category, clone.Request.Category);
            Assert.Equal(original.Request.Priority, clone.Request.Priority);
        }
    }
}