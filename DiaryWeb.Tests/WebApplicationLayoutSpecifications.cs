using System.Collections.Generic;
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
            const string actualTitle="Test Title";
            const string expectedtitle="Test Title";

            //act
            var configuration=Substitute.For<IConfigurationService>();
            configuration.ApplicationTitle.Returns(actualTitle);

            //assert
            Assert.Equal(configuration.ApplicationTitle, expectedtitle);
        }
    }
}
