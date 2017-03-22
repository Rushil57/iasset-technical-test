using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace iasset_technical_test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Method to retrieve cities based on selected country.
        /// </summary>
        /// <param name="country">Country Name</param>
        /// <returns>Returns JSON with list of cities returned by web service.</returns>
        public ActionResult GetCities(string country)
        {
            GlobalWeatherService.GlobalWeather gw = new GlobalWeatherService.GlobalWeather();
            var xmlStringResponse = gw.GetCitiesByCountry(country);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlStringResponse);
            XmlNodeList nodeList = xmlDoc.GetElementsByTagName("City");
            List<string> cities = new List<string>();

            foreach (XmlNode node in nodeList)
            {
                cities.Add(node.InnerText);
            }

            return Json(new { cities });
        }
    }
}