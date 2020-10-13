using System.Threading.Tasks;
using Eduardoproyect.Models.TokenAuth;
using Eduardoproyect.Web.Controllers;
using Shouldly;
using Xunit;

namespace Eduardoproyect.Web.Tests.Controllers
{
    public class HomeController_Tests: EduardoproyectWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}