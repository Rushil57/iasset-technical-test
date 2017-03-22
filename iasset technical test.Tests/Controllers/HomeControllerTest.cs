using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iasset_technical_test;
using iasset_technical_test.Controllers;

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
        public void GetCities()
        {
            var controller = new HomeController();
            var result = controller.GetCities("Australia") as JsonResult;
            Assert.IsNotNull(result);
        }
    }
}
