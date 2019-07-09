using HelloAzureDevops.Controllers;
using Xunit;

namespace HelloAzureDevops.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index()
        {
            var controller = new HomeController();
            var result = controller.Test();

            Assert.Equal("Test", result);
        }
    }
}
