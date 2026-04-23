using CampusFix.Web.Models.Domain;
using CampusFix.Web.Patterns.SimpleFactory;
using Xunit;

namespace CampusFix.Tests.Patterns.SimpleFactory
{
    public class RequestFactoryTests
    {
        [Fact]
        public void CreateRequest_ShouldReturnElectricalRequestCategory()
        {
            var request = RequestFactory.CreateRequest("electrical");

            Assert.NotNull(request);
            Assert.Equal("Electrical", request.Category);
            Assert.Equal("High", request.Priority);
        }

        [Fact]
        public void CreateRequest_ShouldReturnPlumbingRequestCategory()
        {
            var request = RequestFactory.CreateRequest("plumbing");

            Assert.NotNull(request);
            Assert.Equal("Plumbing", request.Category);
            Assert.Equal("Medium", request.Priority);
        }

        [Fact]
        public void CreateRequest_ShouldReturnFurnitureRequestCategory()
        {
            var request = RequestFactory.CreateRequest("furniture");

            Assert.NotNull(request);
            Assert.Equal("Furniture", request.Category);
            Assert.Equal("Low", request.Priority);
        }

        [Fact]
        public void CreateRequest_ShouldThrowException_ForInvalidCategory()
        {
            Assert.Throws<ArgumentException>(() => RequestFactory.CreateRequest("invalid"));
        }
    }
}