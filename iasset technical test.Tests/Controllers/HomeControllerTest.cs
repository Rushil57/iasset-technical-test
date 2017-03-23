using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iasset_technical_test;
using iasset_technical_test.Controllers;
using iasset_technical_test.Services;
using Moq;

namespace iasset_technical_test.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();
           
            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Test()
        {
            string cityName = "Australia";
            // Arrange
            HomeController controller = new HomeController();
            var weatherData = new Mock<IWeatherData>();
            var cities = new List<string>();
            Api.HomeController homeController = new Api.HomeController(weatherData.Object);
            weatherData.Setup(x => x.GetCitiesData(cityName)).Returns(cities);

            var response = homeController.GetCities(cityName);
           
            Assert.IsNotNull(response);
        }
    }
}
