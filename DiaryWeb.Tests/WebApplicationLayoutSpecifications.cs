using System.Collections.Generic;
using System.Web.Mvc;
using DiaryWeb.Controllers;
using DiaryWeb.Services;
using NSubstitute;
using Xunit;

namespace DiaryWeb.Tests
{
    public class WebApplicationLayoutSpecifications
    {
        [Fact]
        public void ConfigurationModule_should_supply_application_name()
        {
            //arrange 
            const string actualName="Test Title";
            const string expectedName="Test Title";
            var configuration=Substitute.For<IConfigurationService>();
            configuration.ApplicationName.Returns(actualName);

            //act

            //assert
            Assert.Equal(configuration.ApplicationName, expectedName);
        }

        [Fact]
        public void HomeController_can_set_application_name()
        {
            //arrange
            const string applicationName="Test Application";
            const string expectedName="Test Application";

            var configuration = Substitute.For<IConfigurationService>();
            configuration.ApplicationName.Returns(applicationName);
            var homeController=new HomeController(configuration);
            //act
            var result = homeController.Index();
            var viewResult=(ViewResult)result;
            var viewData=viewResult.ViewData;

            var actualApplicationName = viewData["ApplicationName"];


            //assert
            Assert.Equal(expectedName, actualApplicationName);
        }
    }
}
