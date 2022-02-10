using System.Threading.Tasks;
using Recipe.Web.Controllers;
using Shouldly;
using Xunit;

namespace Recipe.Web.Tests.Controllers
{
    public class HomeController_Tests: RecipeWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
