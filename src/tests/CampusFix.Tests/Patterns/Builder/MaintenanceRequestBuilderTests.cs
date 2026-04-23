using CampusFix.Web.Patterns.Builder;
using Xunit;

namespace CampusFix.Tests.Patterns.Builder
{
    public class MaintenanceRequestBuilderTests
    {
        [Fact]
        public void Builder_ShouldCreateCompleteRequest()
        {
            var builder = new MaintenanceRequestBuilder();

            var request = builder
                .SetTitle("Broken Light")
                .SetDescription("The residence room light is not working")
                .SetCategory("Electrical")
                .SetPriority("High")
                .Build();

            Assert.NotNull(request);
            Assert.Equal("Broken Light", request.Title);
            Assert.Equal("The residence room light is not working", request.Description);
            Assert.Equal("Electrical", request.Category);
            Assert.Equal("High", request.Priority);
        }
    }
}