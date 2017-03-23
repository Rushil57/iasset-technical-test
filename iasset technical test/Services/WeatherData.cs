using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace iasset_technical_test.Services
{
    public class WeatherData : IWeatherData
    {
        public List<string> GetCitiesData(string country)
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
            return cities;
        }
    }
}